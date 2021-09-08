using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class HeroDAO
    {   ////////////////////////////////////////////
        //Clase para administracion de base de datos

        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;

        //--------------------------------------//
        public HeroDAO()
        {
            this.sqlConnection = new SqlConnection(Properties.Settings.Default.stringConnection);
            this.sqlCommand = new SqlCommand();
            this.sqlCommand.Connection = this.sqlConnection;
        }
        /////----------------//////
        //METODOS BASE DE DATOS////
        /////----------------//////

        public List<Hero> SelectPJs()
        {
            List<Hero> PJs;
            this.sqlCommand.CommandText = "SELECT * FROM PJs";
            if (this.sqlConnection.State != System.Data.ConnectionState.Open)
            {
                this.sqlConnection.Open();
            }
            SqlDataReader oDr = this.sqlCommand.ExecuteReader();
            PJs = new List<Hero>();
            while (oDr.Read())
            {
                string species = oDr["species"].ToString();
                if (species == "Human")
                {
                    PJs.Add(createPj<Human>(oDr));
                }
                else if (species == "Draesirian")
                {
                    PJs.Add(createPj<Draesirian>(oDr));
                }
                else if (species == "Elf")
                {
                    PJs.Add(createPj<Elf>(oDr));
                }
                else if (species == "Faerya")
                {
                    PJs.Add(createPj<Faerya>(oDr));
                }
                else if (species == "Dwarf")
                {
                    PJs.Add(createPj<Dwarf>(oDr));
                }
                else if (species == "Khraldar")
                {
                    PJs.Add(createPj<Khraldar>(oDr));
                }
                else if (species == "Wolvem")
                {
                    PJs.Add(createPj<Wolvem>(oDr));
                }
                else if (species == "Silen")
                {
                    PJs.Add(createPj<Silen>(oDr));
                }
                else
                {
                    int t = 0;
                }
            }
            return PJs;
        }

        public void InsertPJ(Hero pj)
        {
            try
            {
                this.sqlCommand.CommandText = "INSERT INTO PJs(fullName, species, archetype, body, mind, agility, dexterity, strength, constitution, perception, charisma, will, knowledge)" +
                        "VALUES(@fullName, @species, @archetype, @body, @mind, @agility, @dexterity, @strength, @constitution, @perception, @charisma, @will, @knowledge)";
                this.sqlCommand.Parameters.AddWithValue("fullName", pj.FullName);
                this.sqlCommand.Parameters.AddWithValue("species", pj.Species.ToString());
                this.sqlCommand.Parameters.AddWithValue("archetype", pj.Archetype.ToString());
                this.sqlCommand.Parameters.AddWithValue("body", pj.Body);
                this.sqlCommand.Parameters.AddWithValue("mind", pj.Mind);
                this.sqlCommand.Parameters.AddWithValue("agility", pj.Agility);
                this.sqlCommand.Parameters.AddWithValue("dexterity", pj.Dexterity);
                this.sqlCommand.Parameters.AddWithValue("strength", pj.Strength);
                this.sqlCommand.Parameters.AddWithValue("constitution", pj.Constitution);
                this.sqlCommand.Parameters.AddWithValue("perception", pj.Perception);
                this.sqlCommand.Parameters.AddWithValue("charisma", pj.Charisma);
                this.sqlCommand.Parameters.AddWithValue("will", pj.Will);
                this.sqlCommand.Parameters.AddWithValue("knowledge", pj.Knowledge);
                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        public void erasePj(object hero)
        {
            try
            {
                this.sqlCommand.CommandText = "DELETE FROM PJs WHERE fullName =@fullName";
                this.sqlCommand.Parameters.AddWithValue("fullName", ((Hero)hero).FullName);
                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        //------------------------/////
        //-----METODOS MISCELANEOS
        //------------------------/////

        public T createPj<T>(SqlDataReader oDr)
        {
            string fullName = oDr["fullName"].ToString();

            Archetype archetype = ArchetypeSelect(oDr["archetype"].ToString());

            int body;
            int.TryParse(oDr["body"].ToString(), out body);

            int mind;
            int.TryParse(oDr["mind"].ToString(), out mind);

            int agility;
            int.TryParse(oDr["agility"].ToString(), out agility);

            int dexterity;
            int.TryParse(oDr["dexterity"].ToString(), out dexterity);

            int strength;
            int.TryParse(oDr["strength"].ToString(), out strength);

            int constitution;
            int.TryParse(oDr["constitution"].ToString(), out constitution);

            int perception;
            int.TryParse(oDr["perception"].ToString(), out perception);

            int charisma;
            int.TryParse(oDr["charisma"].ToString(), out charisma);

            int will;
            int.TryParse(oDr["will"].ToString(), out will);

            int knowledge;
            int.TryParse(oDr["knowledge"].ToString(), out knowledge);
            T createdPj = (T)Activator.CreateInstance(typeof(T), new object[] {fullName,
                archetype, body, agility, dexterity, strength, constitution, mind, perception, charisma,
                will, knowledge });
            return createdPj;
        }

        public Archetype ArchetypeSelect(string archetype)
        {
            if (archetype == "belligerent")
            {
                return Archetype.belligerent;
            }
            else if (archetype == "occultist")
            {
                return Archetype.occultist;
            }
            else if (archetype == "tracker")
            {
                return Archetype.tracker;
            }
            else if (archetype == "enlightened")
            {
                return Archetype.enlightened;
            }

            return Archetype.normal;

        }

    }
}
