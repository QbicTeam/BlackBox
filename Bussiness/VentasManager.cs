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

        private const string FLD_VENTAID = "ventaId";
        private const string FLD_FECHAHORA = "fechaHora";
        private const string FLD_CAJERO = "cajero";
        private const string FLD_RECIBO = "recibo";
        private const string FLD_CANTIDAD_ARTICULOS = "cantidadArticulos";
        private const string FLD_SUBTOTAL = "subTotal";
        private const string FLD_IMPUESTOS = "Impuestos";
        private const string FLD_TOTAL = "total";
        private const string FLD_EN_CORTE = "enCorte";
        private const string FLD_CANCELADO = "cancelado";
        //--
        private const string FLD_ID = "Id";
        private const string FLD_PRODUCTO = "Producto";
        private const string FLD_CANTIDAD = "Cantidad";
        private const string FLD_PRECIO = "Precio";
        private const string FLD_NIVEL = "Nivel";
        private const string FLD_PRODUCTO_PADRE = "ProductoPadre";
        //--
        private const string FLD_NOPRODUCTOS = "NoProductos"; 
        private const string FLD_VENTA = "Venta";
        private const string FLD_VENTA_TOTAL = "VentaTotal";

        private const string PRM_VTA = "vta";
        private const string PRM_VTA_DT = "vtaDT";
        private const string PRM_NORECIBO = "noRecibo";
        private const string PRM_VTAID = "vtaId";
        private const string PRM_CAJERO = "cajero";
        private const string PRM_CORTE = "corte"; 

        private const string SP_SAVE_VENTAS = "ventas_save";
        private const string SP_UPDATE_VENTA = "ventas_update";
        private const string SP_SAVE_VENTASDT = "ventasDT_save";

        private const string SP_GET_TICKET = "getTicket";
        private const string SP_CANCEL_TICKET = "cancelTicket";
        private const string SP_GET_VENTAS = "getVentas";
        private const string SP_GET_VENTAS_CAJERO = "getVentasCajero";
        private const string SP_GET_VENTAS_SIN_CORTE = "getVentasSinCorte";
        private const string SP_GET_CORTEZ = "getCorteZ";
        private const string SP_DELETE_VENTAS = "deleteVentas";
        private const string SP_CERRAR_CORTE_CAJERO = "cerrarCorteCajero";

        /*
        -- getTicket](@noRecibo varchar(15))
 -- cancelTicket](@vtaId int)
 -- getVentas]
 -- getVentasCajero] (@cajero varchar(100))
 -- getVentasSinCorte]
 -- getCorteZ]
        cerrarCorteCajero](@cajero varchar(100), @corte int)*/

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
            prm.ParameterName = PRM_VTA;
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
            prm.ParameterName = PRM_VTA_DT;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Xml;            
            prm.Value = xml;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            this._conn.Close();

            return id > 0 ? true : false;
        }

        public Venta GetTicket(string noRecibo)
        {
            var vtas = new List<Venta>();
            var vta = new Venta();
            
            SqlCommand cmd = new SqlCommand(SP_GET_TICKET, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = PRM_NORECIBO;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 15;
            prm.Value = noRecibo;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            vtas = FillVentas(reader);

            if (vtas.Count > 0)
                vta = vtas[0];

            this._conn.Close();

            return vta;
        }

        private List<Venta> FillVentas(SqlDataReader reader)
        {
            var vtas = new List<Venta>();
            var vta = new Venta();
            var dt = new VentaDT();

            var vtaId = 0;
            if (reader.Read())
            {
                if (vtaId != Convert.ToInt32(reader[FLD_VENTAID]))
                {
                    vta = new Venta();
                    //{
                    //    VentaId = Convert.ToInt32(reader[FLD_VENTAID]),
                    //    FechaHora = Convert.ToDateTime(reader[FLD_FECHAHORA]),
                    //    Cajero = reader[FLD_CAJERO].ToString(),
                    //    Recibo = reader[FLD_RECIBO].ToString(),
                    //    CantidadArticulos = Convert.ToInt32(reader[FLD_CANTIDAD_ARTICULOS]),
                    //    Total = Convert.ToDecimal(reader[FLD_TOTAL]),
                    //    SubTotal = Convert.ToDecimal(reader[FLD_SUBTOTAL]),
                    //    EnCorte = Convert.ToInt32(reader[FLD_EN_CORTE]),
                    //    Cancelado = Convert.ToBoolean(reader[FLD_CANCELADO])
                    //};

                    vta.VentaId = Convert.ToInt32(reader[FLD_VENTAID]);
                    vta.FechaHora = Convert.ToDateTime(reader[FLD_FECHAHORA]);
                    vta.Cajero = reader[FLD_CAJERO].ToString();
                    vta.Recibo = reader[FLD_RECIBO].ToString();
                    vta.CantidadArticulos = Convert.ToInt32(reader[FLD_CANTIDAD_ARTICULOS]);
                    vta.Total = Convert.ToDecimal(reader[FLD_TOTAL]);
                    vta.Impuestos = Convert.ToDecimal(reader[FLD_IMPUESTOS]);
                    vta.EnCorte = Convert.ToInt32(reader[FLD_EN_CORTE]);
                    vta.Cancelado = Convert.ToBoolean(reader[FLD_CANCELADO]);

                    vta.SubTotal = vta.Total - vta.Impuestos;
                    vta.Productos = new List<VentaDT>();

                    vtas.Add(vta);
                }

                dt = new VentaDT()
                {
                    Id = Convert.ToInt32(reader[FLD_ID]),
                    VentaId = Convert.ToInt32(reader[FLD_VENTAID]),
                    Producto = reader[FLD_PRODUCTO].ToString(),
                    Cantidad = Convert.ToInt32(reader[FLD_CANTIDAD]),
                    Precio = Convert.ToDecimal(reader[FLD_PRECIO]),
                    Nivel = Convert.ToInt32(reader[FLD_NIVEL]),
                    ProductoPadre = reader[FLD_PRODUCTO_PADRE].ToString()
                };

                vta.Productos.Add(dt);
            }

            return vtas;
        }
        public bool CancelTicket(int vtaId)
        {
            var result = true;
 
            SqlCommand cmd = new SqlCommand(SP_CANCEL_TICKET, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = PRM_VTAID;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Int;
            prm.Value = vtaId;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            cmd.ExecuteNonQuery();

            this._conn.Close();

            return result;
        }

        public List<Venta> GetVentas(ref decimal ventaTotal)
        {
            var vtas = new List<Venta>();

            SqlCommand cmd = new SqlCommand(SP_GET_VENTAS, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            vtas = FillVentas(reader);

            reader.NextResult();

            if (reader.Read())
            {
                ventaTotal = Convert.ToDecimal(reader[FLD_VENTA_TOTAL]);
            }

            this._conn.Close();
            
            return vtas;
        }
        public List<Venta> GetVentasCajero(string cajero, ref decimal ventaTotal)
        {
            var vtas = new List<Venta>();

            SqlCommand cmd = new SqlCommand(SP_GET_VENTAS_CAJERO, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = PRM_CAJERO;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 100;
            prm.Value = cajero;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            vtas = FillVentas(reader);

            reader.NextResult();

            if (reader.Read())
            {
                ventaTotal = Convert.ToDecimal(reader[FLD_VENTA_TOTAL]);
            }

            this._conn.Close();

            return vtas;
        }
        public List<Venta> GetVentasSinCorte(ref decimal ventaTotal)
        {
            var vtas = new List<Venta>();

            SqlCommand cmd = new SqlCommand(SP_GET_VENTAS_SIN_CORTE, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            vtas = FillVentas(reader);

            reader.NextResult();

            if (reader.Read())
            {
                ventaTotal = Convert.ToDecimal(reader[FLD_VENTA_TOTAL]);
            }

            this._conn.Close();

            return vtas;
        }
        public CorteZ GetCorteZ()
        {
            var cortez = new CorteZ();
            var prodz = new ProductoZ();
            cortez.Productos = new List<ProductoZ>();

            SqlCommand cmd = new SqlCommand(SP_GET_CORTEZ, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            this._conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                prodz = new ProductoZ()
                { 
                    Producto = reader[FLD_PRODUCTO].ToString(),
                    NoProductos = Convert.ToInt32(reader[FLD_NOPRODUCTOS]),
                    Venta = Convert.ToDecimal(reader[FLD_VENTA])
                };

                cortez.Productos.Add(prodz);
            }

            reader.NextResult();

            if (reader.Read())
            {
                cortez.VentaTotal = Convert.ToDecimal(reader[FLD_VENTA_TOTAL]);
            }

            this._conn.Close();

            return cortez;
        }
        public void DeleteVentas()
        {

            SqlCommand cmd = new SqlCommand(SP_DELETE_VENTAS, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            this._conn.Open();

            cmd.ExecuteNonQuery();

            this._conn.Close();

            // TODO Fuera de aqui se debe crear el archivo JSON

        }

        public void CerrarCorteCajero(string cajero, int corte)
        {
            SqlCommand cmd = new SqlCommand(SP_CERRAR_CORTE_CAJERO, this._conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = PRM_CAJERO;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.VarChar;
            prm.Size = 100;
            prm.Value = cajero;
            cmd.Parameters.Add(prm);

            prm = new SqlParameter();
            prm.ParameterName = PRM_CORTE;
            prm.Direction = ParameterDirection.Input;
            prm.SqlDbType = SqlDbType.Int;
            //prm.Size = 100;
            prm.Value = corte;
            cmd.Parameters.Add(prm);

            this._conn.Open();

            cmd.ExecuteNonQuery();

            this._conn.Close();
        }
    }
}
