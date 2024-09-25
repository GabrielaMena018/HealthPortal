using HealthPortal.Controller.InventoryAdministration;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using HealthPortal.View.InventoryAdministration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthPortal.Model.DAO
{
    internal class DAOCategoryAdministration  : DTOCategoryAdministration 
    {
        readonly SqlCommand command = new SqlCommand();
        public int RegisterCategory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Inventario].[tbCategoriaMedicamento] VALUES (@param1)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", MedicineCategory);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                CommonMethods.HandleError("EC_111");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_111");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateCategory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Inventario].[tbCategoriaMedicamento] SET [categoriaMedicamento] = (@param1) WHERE [idCategoriaMedicamento] = @param2 ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", MedicineCategory);
                cmd.Parameters.AddWithValue("param2", CategoryID);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                CommonMethods.HandleError("EC_311");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_311");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet GetCategory()
        {
            try
            {
                
                //Se crea una conexion para garantizar que haya conexion con la base
                command.Connection = getConnection();
                string query = "SELECT * FROM [Inventario].[tbCategoriaMedicamento]";
                SqlCommand cmdCategory = new SqlCommand(query, command.Connection);
                cmdCategory.ExecuteNonQuery();
                SqlDataAdapter adpCategory = new SqlDataAdapter(cmdCategory);
                DataSet ds = new DataSet();
                adpCategory.Fill(ds, "tbCategoriaMedicamento");
                return ds;
                
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
