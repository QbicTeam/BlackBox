using BlackBox.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackBox.Bussiness
{
    public class VentasManager
    {
        private SqlConnection _conn;

        /* private const string FLD_VENTAID = "ventaId";
        private const string FLD_FECHAHORA = "fechaHora";
        private const string FLD_CAJERO = "cajero";
        private const string FLD_RECIBO = "recibo";
        private const string FLD_CANTIDAD_ARTICULOS = "cantidadArticulos";
        private const string FLD_SUBTOTAL = "subTotal";
        private const string FLD_IMPUESTOS = "Impuestos";
        private const string FLD_TOTAL = "total";
        private const string FLD_EN_CORTE = "enCorte";
        private const string FLD_CANCELADO = "cancelado";*/
        private const string FLD_VTA = "vta";
        private const string FLD_VTA_DT = "vtaDT";


        private const string SP_SAVE_VENTAS = "ventas_save";
        private const string SP_UPDATE_VENTA = "ventas_update";
        private const string SP_SAVE_VENTASDT = "ventasDT_save";


        public VentasManager(string connectionString)
        {
            this._conn = new SqlConnection(connectionString);
        }

        public int SaveVenta(Venta vta)
        {
            

            SqlCommand cmd = new SqlCommand(SP_SAVE_VENTAS, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;


            string xml;

            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(vta.GetType());
                serializer.Serialize(stringwriter, vta);
                xml = stringwriter.ToString();
            }

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = FLD_VTA;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Xml;
            //prm.Size = 100;
            prm.Value = xml;
            cmd.Parameters.Add(prm);

            

            this._conn.Open();

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            
            this._conn.Close();

            return id;
        }
        public bool SaveVentaDT(Venta vta)
        {


            SqlCommand cmd = new SqlCommand(SP_SAVE_VENTASDT, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;


            string xml;

            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(vta.GetType());
                serializer.Serialize(stringwriter, vta);
                xml = stringwriter.ToString();
            }

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = FLD_VTA_DT;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Xml;
            //prm.Size = 100;
            prm.Value = xml;
            cmd.Parameters.Add(prm);



            this._conn.Open();

            int id = Convert.ToInt32(cmd.ExecuteScalar());


            this._conn.Close();

            return id > 0 ? true : false;
        }

    }
}
