using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.IO;

namespace Zadaca2
{
    public partial class FormFunctions : Form
    {
        string nameTransfer;
        int pratiId, idPieceProp;
        List<Machine> machines = new List<Machine>();
        List<Piece> foundPieces = new List<Piece>();
        List<ReportPiece> piecesForReport = new List<ReportPiece>();
        List<Property> getPropertiesForPartID = new List<Property>();
        SortedList<int, int> partId = new SortedList<int, int>();
        SortedList<int, string> usedMaterial = new SortedList<int, string>();
        SortedList<int, string> pieceTypeID = new SortedList<int, string>();
        SortedList<int, string> operatorsID = new SortedList<int, string>();
        List<Property> propertinaPart = new List<Property>();
        SortedList<int, List<Property>> propertina = new SortedList<int, List<Property>>();
        public FormFunctions()
        {
            InitializeComponent();
        }
        public FormFunctions(string s)
        {
            InitializeComponent();
            labelMagnifyingGlass.Hide();

            listViewPieces.View = System.Windows.Forms.View.Details;
            listViewPieces.GridLines = true;
            listViewPieces.FullRowSelect = true;
            listViewPieces.Columns.Add("Сериски број", 150);
            listViewPieces.Columns.Add("Тип на дел", 150);
            listViewPieces.Columns.Add("Материјал", 150);
            listViewPieces.Columns.Add("Производител", 150);

            listViewMachines.View = System.Windows.Forms.View.Details;
            listViewMachines.GridLines = true;
            listViewMachines.FullRowSelect = true;
            listViewMachines.Columns.Add("Име на машина", 350);

            machines = ReadDataMFromSQL();
            FillComboBoxMachineType();
            FillComboBoxMachine();


            partId = PartIdRead();
            usedMaterial = UsedMaterialTypeIdRead();
            pieceTypeID = PieceTypeIdRead();
            operatorsID = OperatorsIdRead();
            foreach (Machine m in machines)
            {
                listViewMachines.Items.Add(m.name);
            }
            nameTransfer = s;

            listViewReport.View = System.Windows.Forms.View.Details;
            listViewReport.GridLines = true;
            listViewReport.FullRowSelect = true;
            listViewReport.Columns.Add("Сериски број");
            listViewReport.Columns.Add("Датум на внес");

            getSizeOfDB();
            cmbDataBaseFill();
        }
        public bool existSerialNum(int serialNum)
        {
            bool goIma = false;
            try
            {
                string connString;
                SqlCommand cmd;
                SqlConnection con;
                SqlDataReader dataReader;
                string sql;

                // Povrzuvanje so baza

                connString = Program.connectionString;
                con = new SqlConnection(connString);
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Проблем со пронајдување на сериски број!");
                }
                // Citanje na podatocite od bazata,tabela : ProductionPiece

                sql = "Select SerialNumber FROM [Data Schema].ProductionPiece";

                cmd = new SqlCommand(sql, con);
                dataReader = cmd.ExecuteReader();

                try
                {
                    while (dataReader.Read())
                    {
                        int serialNumber;

                        serialNumber = Convert.ToInt32(dataReader.GetValue(0).ToString());

                        if (serialNum == serialNumber)
                        {
                            goIma = true;
                            dataReader.Close();
                            break;
                        }
                        else
                        {
                            goIma = false;
                            continue;
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Проблем со пронајдување на сериски број!");
                }
            }
            catch
            {
                MessageBox.Show("Проблем со пронајдување на сериски број!");
            }

            return goIma;
        }
        // -------- Tab-Definiranje na masina --------
        private void btDefineM_Click(object sender, EventArgs e)
        {
            try
            {
                string connString;
                SqlCommand cmd;
                SqlConnection con;
                SqlDataReader dataReader;
                string sql;

                if (String.IsNullOrEmpty(tbNameM.Text) || String.IsNullOrEmpty(tbDescriptionM.Text) || String.IsNullOrEmpty(cbTypeM.Text))
                {
                    MessageBox.Show("Не ги оставајте полињата празни!");
                    return;
                }

                string ime, tip, opis;

                ime = tbNameM.Text;
                tip = cbTypeM.Text;
                opis = tbDescriptionM.Text;

                // Povrzuvanje so baza

                connString = Program.connectionString;
                con = new SqlConnection(connString);
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Проблем со поврзување со базата!");
                    return;
                }
                // Citanje na podatocite od bazata,tabela : MachineType

                sql = "Select ID,Type FROM [Config Schema].MachineType";

                cmd = new SqlCommand(sql, con);
                dataReader = cmd.ExecuteReader();

                int ID = 0;

                try
                {
                    while (dataReader.Read())
                    {
                        string type;
                        int id;

                        id = Convert.ToInt32(dataReader.GetValue(0).ToString());
                        type = dataReader.GetValue(1).ToString();

                        if (type == tip)
                        {
                            dataReader.Close();
                            ID = id;
                            break;
                        }
                    }
                    dataReader.Close();

                    con.Close();

                    Machine machine = new Machine(ime, ID, opis);
                    WriteDataMToSQL(machine);
                    machines.Add(machine);
                    listViewMachines.Items.Add(machine.name);

                    MessageBox.Show("Успешно ја дефиниравте машината!");
                    tbNameM.Text = "";
                    cbTypeM.Text = "";
                    tbDescriptionM.Text = "";
                    FillComboBoxMachine();
                }
                catch
                {
                    MessageBox.Show("Има проблем со внесување на податоците во база!");
                }
            }
            catch
            {
                MessageBox.Show("Има проблем со конекцијата со базата!");
            }
        }
        private void btOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNajava formNajava = new FormNajava();
            formNajava.Show();
        }

        // -------- Tab-Definiranje na parce --------
     
        public void WriteDataPToSQL(Piece p)
        {
            string connString;
            SqlCommand cmd;
            SqlConnection con;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
                return;
            }

            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Data Schema].ProductionPiece')";

            cmd = new SqlCommand(sql, con);


            cmd.CommandText = @"INSERT INTO [Data Schema].ProductionPiece (SerialNumber,PartID,OperatorID,Timestamp) VALUES (@serialNum, @partID, @operatorID, @timestamp)";

            cmd.Parameters.AddWithValue("@serialNum", p.serialNum);
            cmd.Parameters.AddWithValue("@partID", p.partId);
            cmd.Parameters.AddWithValue("@operatorID", p.operatorID);
            cmd.Parameters.AddWithValue("@timestamp", p.time);
            cmd.ExecuteNonQuery();

            con.Close();

        }
        public void WriteDataMToSQL(Machine m)
        {
            string connString;
            SqlCommand cmd;
            SqlConnection con;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
                return;
            }

            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Config Schema].DefinedMachines')";

            cmd = new SqlCommand(sql, con);


            cmd.CommandText = @"INSERT INTO [Config Schema].DefinedMachines (MachineTypeID,Name,Description) VALUES (@machineTypeID, @name, @description)";

            cmd.Parameters.AddWithValue("@name", m.name);
            cmd.Parameters.AddWithValue("@machineTypeID", m.type);
            cmd.Parameters.AddWithValue("@description", m.description);
            cmd.ExecuteNonQuery();

            con.Close();

        }
        public List<Machine> ReadDataMFromSQL()
        {
            List<Machine> machinesM = new List<Machine>();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            try
            {
                // Citanje na podatocite od bazata,tabela : DefinedMachines

                sql = "Select MachineTypeID,Name,Description FROM [Config Schema].DefinedMachines";

                cmd = new SqlCommand(sql, con);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string name, description;
                    int idType;

                    idType = Convert.ToInt32(dataReader.GetValue(0).ToString());
                    name = dataReader.GetValue(1).ToString();
                    description = dataReader.GetValue(2).ToString();

                    Machine m = new Machine(name, idType, description);
                    machinesM.Add(m);
                }
                dataReader.Close();
            }

            catch
            {
            }
            con.Close();
            return machinesM;
        }
        private void FillComboBoxMachineType()
        {
            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            try
            {
                // Citanje na podatocite od bazata,tabela : DefinedMachines

                sql = "select [Config Schema].MachineType.Type from[Config Schema].MachineType ";

                cmd = new SqlCommand(sql, con);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string t;

                    t = dataReader.GetValue(0).ToString();

                    cbTypeM.Items.Add(t);
                }
                dataReader.Close();
            }

            catch
            {
            }
            con.Close();

        }
        public SortedList<int, string> OperatorsIdRead()
        {
            SortedList<int, string> operatorsId = new SortedList<int, string>();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;


            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            sql = "Select ID,UserName FROM [Config Schema].Operators";

            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int idOperator;
                string userName;
                idOperator = Convert.ToInt32(dataReader.GetValue(0).ToString());
                userName = dataReader.GetValue(1).ToString();

                operatorsId.Add(idOperator, userName);
            }
            dataReader.Close();
            con.Close();

            return operatorsId;
        }
        public SortedList<int, string> PieceTypeIdRead()
        {
            SortedList<int, string> pieceTypeId = new SortedList<int, string>();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }
            sql = "Select ID,Name FROM [Config Schema].ProductionPart";

            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int id;
                string type;
                id = Convert.ToInt32(dataReader.GetValue(0).ToString());
                type = dataReader.GetValue(1).ToString();

                pieceTypeId.Add(id, type);
                cbTypeP.Items.Add(type);
            }
            dataReader.Close();
            con.Close();

            return pieceTypeId;
        }
        public SortedList<int, string> UsedMaterialTypeIdRead()
        {
            SortedList<int, string> usedMaterialTypeId = new SortedList<int, string>();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            sql = "Select ID,UsedMaterialType FROM [Config Schema].UsedMaterialType";

            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                int idMaterial;
                string usedMatType;
                idMaterial = Convert.ToInt32(dataReader.GetValue(0).ToString());
                usedMatType = dataReader.GetValue(1).ToString();

                usedMaterialTypeId.Add(idMaterial, usedMatType);
                cbMaterialType.Items.Add(usedMatType);

            }
            dataReader.Close();
            con.Close();

            return usedMaterialTypeId;
        }
        public SortedList<int, int> PartIdRead()
        {
            SortedList<int, int> partIdP = new SortedList<int, int>();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            sql = "Select ID,SerialNumber FROM [Data Schema].ProductionPiece";

            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                int serialNum;
                int idPiece;
                idPiece = Convert.ToInt32(dataReader.GetValue(0).ToString());
                serialNum = Convert.ToInt32(dataReader.GetValue(1).ToString());

                partIdP.Add(idPiece, serialNum);
            }
            dataReader.Close();
            con.Close();

            return partIdP;
        }
        public void FillComboBoxMachine()
        {
            cbSearchM.Items.Clear();
            for (int i = 0; i < machines.Count; i++)
            {
                cbSearchM.Items.Add(machines[i].name);
            }
        }

        private void listViewPieces_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            int serNum;
            List<Property> nemaProperty;

            if (listViewPieces.SelectedItems.Count == 1)
            {
                index = listViewPieces.FocusedItem.Index;
            }
            else
            {
                return;
            }

            foreach (Piece p in foundPieces)
            {
                if (listViewPieces.Items[index].SubItems[0].Text == p.serialNum.ToString())
                {
                    //p.Properties.Clear();
                    idPieceProp = Convert.ToInt32(p.stringUsedMaterials.PieceId);
                    pratiId = p.partId;
                    serNum = p.serialNum;
                    nemaProperty = isExistPartProp(pratiId, serNum);
                    for (int i = 0; i < nemaProperty.Count; i++)
                        p.Properties.Add(nemaProperty[i]);

                    var source = new BindingSource();
                    source.DataSource = p.Properties;
                    PiecesPropDataGridView.DataSource = source;
                    break;
                }
            }
        }

        private List<Property> isExistPartProp(int IDpart, int serNum)
        {
            List<Property> nemaProperty = new List<Property>();

            foreach (var item in propertinaPart)
            {
                foreach (var it in propertina)
                {
                    if (it.Key == serNum)
                    {
                        bool flag = false;


                        foreach (Property prop in it.Value)
                        {
                            if (item.ID == prop.ID)
                            {
                                flag = true;
                                break;

                            }

                        }

                        if (!flag)
                            nemaProperty.Add(item);

                    }
                }
            }
            return nemaProperty;
        }

        private void FormFunctions_Load(object sender, EventArgs e)
        {
            dtpSearchT.Value = dtpSearchT.MinDate;
        }

        public List<Piece> ReadDataPieceFromSQL(string sn, string m, DateTimePicker dt)
        {
            listViewPieces.Items.Clear();
            List<Property> properties = new List<Property>();
            List<Piece> piecesFromDb = new List<Piece>();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            SqlDataReader dataReader;
            string sql;

            string choice;
            int flag;


            SqlCommand cmd1 = new SqlCommand();

            connString = Program.connectionString + " MultipleActiveResultSets=true";
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            try
            {
                // Citanje na podatocite od bazata,tabela : Sekoja so join :D

                if (String.IsNullOrEmpty(sn) && String.IsNullOrEmpty(m) && dt.Value == dt.MinDate)
                {
                    choice = "";
                    flag = 0;
                }
                else if (String.IsNullOrEmpty(m) && dt.Value == dt.MinDate)
                {
                    choice = "where [Data Schema].ProductionPiece.SerialNumber = @sn";
                    flag = 1;

                }
                else if (String.IsNullOrEmpty(m))
                {
                    choice = "where [Data Schema].ProductionPiece.SerialNumber = @sn and [Data Schema].ProductionPiece.Timestamp = @dtp";
                    flag = 2;

                }
                else if (String.IsNullOrEmpty(m) && String.IsNullOrEmpty(sn))
                {
                    choice = "where [Data Schema].ProductionPiece.Timestamp = @dtp";
                    flag = 3;

                }
                else if (String.IsNullOrEmpty(sn) && dt.Value == dt.MinDate)
                {
                    choice = "where [Config Schema].ProductionPart.Name = (select [Config Schema].MachineType.Type " +
                       "from[Config Schema].MachineType " +
                       "join[Config Schema].DefinedMachines " +
                       "on[Config Schema].DefinedMachines.MachineTypeID = [Config Schema].MachineType.ID " +
                       "where[Config Schema].DefinedMachines.Name = @m)";
                    flag = 4;

                }
                else if (dt.Value == dt.MinDate)
                {
                    choice = "where [Config Schema].ProductionPart.Name = (select [Config Schema].MachineType.Type " +
                      "from[Config Schema].MachineType " +
                      "join[Config Schema].DefinedMachines " +
                      "on[Config Schema].DefinedMachines.MachineTypeID = [Config Schema].MachineType.ID " +
                      "where[Config Schema].DefinedMachines.Name = @m) and [Config Schema].ProductionPart.Name = 'Generic' " +
                      "and [Data Schema].ProductionPiece.SerialNumber = @sn";
                    flag = 5;

                }
                else if (String.IsNullOrEmpty(sn))
                {
                    choice = "where [Config Schema].ProductionPart.Name = (select [Config Schema].MachineType.Type " +
                      "from[Config Schema].MachineType " +
                      "join[Config Schema].DefinedMachines " +
                      "on[Config Schema].DefinedMachines.MachineTypeID = [Config Schema].MachineType.ID " +
                      "where[Config Schema].DefinedMachines.Name = @m) and [Config Schema].ProductionPart.Name = 'Generic' " +
                      "and [Data Schema].ProductionPiece.Timestamp = @dtp";
                    flag = 6;

                }
                else
                {
                    choice = "where [Config Schema].ProductionPart.Name = (select [Config Schema].MachineType.Type " +
                     "from[Config Schema].MachineType " +
                     "join[Config Schema].DefinedMachines " +
                     "on[Config Schema].DefinedMachines.MachineTypeID = [Config Schema].MachineType.ID " +
                     "where[Config Schema].DefinedMachines.Name = @m) and [Config Schema].ProductionPart.Name = 'Generic' " +
                     "and [Data Schema].ProductionPiece.Timestamp = @dtp and [Data Schema].ProductionPiece.SerialNumber = @sn";
                    flag = 7;

                }
                sql = "select [Data Schema].ProductionPiece.SerialNumber,[Config Schema].ProductionPart.Name, " +
                    "[Config Schema].UsedMaterialType.UsedMaterialType,[Config Schema].UsedMaterialManufacturer.Name,[Data Schema].UsedMaterials.PieceID, " +
                    "[Data Schema].ProductionPiece.PartID " +
                    "from [Data Schema].ProductionPiece " +
                    "join [Data Schema].UsedMaterials " +
                    "on [Data Schema].UsedMaterials.PieceID = [Data Schema].ProductionPiece.ID " +
                    "join [Config Schema].ProductionPart " +
                    "on [Config Schema].ProductionPart.ID = [Data Schema].ProductionPiece.PartID " +
                    "join [Config Schema].UsedMaterialType " +
                    "on [Config Schema].UsedMaterialType.ID = [Data Schema].UsedMaterials.UsedMaterialTypeID " +
                    "join [Config Schema].UsedMaterialManufacturer " +
                    "on [Config Schema].UsedMaterialManufacturer.ID = [Data Schema].UsedMaterials.ManufacturerID " + choice;
                cmd = new SqlCommand(sql, con);
                if (flag == 1)
                {
                    cmd.Parameters.AddWithValue("@sn", sn);
                }
                else if (flag == 2)
                {
                    cmd.Parameters.AddWithValue("@sn", sn);
                    cmd.Parameters.AddWithValue("@dtp", dt.Value);
                }
                else if (flag == 3)
                {
                    cmd.Parameters.AddWithValue("@dtp", dt.Value);
                }
                else if (flag == 4)
                {
                    cmd.Parameters.AddWithValue("@m", m);
                }
                else if (flag == 5)
                {
                    cmd.Parameters.AddWithValue("@m", m);
                    cmd.Parameters.AddWithValue("@sn", sn);
                }
                else if (flag == 6)
                {
                    cmd.Parameters.AddWithValue("@m", m);
                    cmd.Parameters.AddWithValue("@dtp", dt.Value);
                }
                else if (flag == 7)
                {
                    cmd.Parameters.AddWithValue("@m", m);
                    cmd.Parameters.AddWithValue("@dtp", dt.Value);
                    cmd.Parameters.AddWithValue("@sn", sn);
                }
                dataReader = cmd.ExecuteReader();

                SqlDataReader dataReader1;
                while (dataReader.Read())
                {
                    string t, mat, mm;
                    int sN, pID, pI;

                    sN = Convert.ToInt32(dataReader.GetValue(0).ToString());
                    t = dataReader.GetValue(1).ToString();
                    mat = dataReader.GetValue(2).ToString();
                    mm = dataReader.GetValue(3).ToString();
                    pI = dataReader.GetInt32(4);
                    pID = Convert.ToInt32(dataReader.GetValue(5).ToString());

                    //// Odi vo PropValues,PropDefine

                    String query = "select [Data Schema].ProductionPiecePropertiesDefinition.Name, " +
                        "[Data Schema].ProductionPiecePropertiesDefinition.ID " +
                        "from[Data Schema].ProductionPiecePropertiesDefinition " +
                        "where[Data Schema].ProductionPiecePropertiesDefinition.PartID = @PartID";

                    cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@PartID", pID);

                    dataReader1 = cmd1.ExecuteReader();
                    string ime = "";
                    int vrednost = 0;
                    int id = 0;
                    while (dataReader1.Read())
                    {
                        ime = dataReader1.GetValue(0).ToString();
                        id = dataReader1.GetInt32(1);

                        PartPropFill(pID);
                        Property p = new Property(id, ime, vrednost);
                        properties.Add(p);
                    }
                    dataReader1.Close();


                    String queryPropertiesValues = "select [Data Schema].ProductionPiecePropertiesDefinition.ID, " +
                        "[Data Schema].ProductionPiecePropertiesValue.Value " +
                        "from[Data Schema].ProductionPiecePropertiesValue " +
                        "right join[Data Schema].ProductionPiecePropertiesDefinition " +
                        "on[Data Schema].ProductionPiecePropertiesDefinition.ID = [Data Schema].ProductionPiecePropertiesValue.PropertyID " +
                        "where[Data Schema].ProductionPiecePropertiesValue.PieceID = @PieceID";

                    SqlCommand commandPropValues = new SqlCommand(queryPropertiesValues, con);
                    commandPropValues.Parameters.AddWithValue("@PieceID", pI);
                    SqlDataReader readerProps = commandPropValues.ExecuteReader();
                    while (readerProps.Read())
                    {
                        int propertyId = readerProps.GetInt32(0);
                        foreach (Property prop in properties)
                        {
                            if (prop.ID == propertyId)
                            {
                                prop.Value = readerProps.GetInt32(1);
                            }
                        }
                    }
                    readerProps.Close();

                    StringUsedMaterials um = new StringUsedMaterials(t, mat, mm, pI.ToString());
                    Piece piece = new Piece(sN, um);
                    piece.partId = pID;

                    piece.Properties = properties;
                    getPropertiesForPartID = properties;
                    properties = new List<Property>();
                    piecesFromDb.Add(piece);

                }
                dataReader.Close();

            }

            catch
            {
                MessageBox.Show("Има проблем со читање на податоците од база!");
                return null;
            }
            con.Close();
            return piecesFromDb;
        }

        private void PartPropFill(int partId)
        {
            string connString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;

            connString = Program.connectionString + " MultipleActiveResultSets=true";
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }
            try
            {

                sql = "select [Data Schema].ProductionPiecePropertiesDefinition.Name, " +
                    "[Data Schema].ProductionPiecePropertiesDefinition.ID " +
                    "from[Data Schema].ProductionPiecePropertiesDefinition " +
                    "where[Data Schema].ProductionPiecePropertiesDefinition.PartID = @partId";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@partId", partId);
                dataReader = cmd.ExecuteReader();

                int value = 0;
                string ime = "";
                List<Property> partProperties = new List<Property>();

                while (dataReader.Read())
                {
                    ime = dataReader.GetValue(0).ToString();

                    int id = dataReader.GetInt32(1);

                    Property p = new Property(id, ime, value);
                    partProperties.Add(p);


                    propertinaPart = partProperties;
                }
                partProperties = new List<Property>();
                dataReader.Close();
            }

            catch
            {
                MessageBox.Show("Има проблем со читање на податоците од база!");
                return;
            }
            con.Close();

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            foundPieces.Clear();
            foundPieces = ReadDataPieceFromSQL(tbSearchSN.Text, cbSearchM.Text, dtpSearchT);
            foreach (Piece p in foundPieces)
            {
                ListViewItem item;
                string[] arr = new string[4];

                arr[0] = p.serialNum.ToString();
                arr[1] = p.stringUsedMaterials.Type.ToString();
                arr[2] = p.stringUsedMaterials.MaterialTypeId.ToString();
                arr[3] = p.stringUsedMaterials.ManufacturerId.ToString();
                propertina[p.serialNum] = p.Properties;
                item = new ListViewItem(arr);
                listViewPieces.Items.Add(item);
            }
        }

        private void btDefineProp_Click(object sender, EventArgs e)
        {
            string connString;
            SqlConnection con;
            SqlCommand cmd;
            string sql;
            bool choice = false;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }
            try
            {

                if ((rbGeneric.Checked == false && rbATL.Checked == false && rbAFP.Checked == false) || string.IsNullOrEmpty(tbProperty.Text))
                {
                    MessageBox.Show("Полињата не смеат да останат празни!");
                    tbProperty.Text = "";
                    if (rbAFP.Checked || rbATL.Checked || rbGeneric.Checked)
                    {
                        rbAFP.Checked = false;
                        rbATL.Checked = false;
                        rbGeneric.Checked = false;
                    }
                    return;
                }

                sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Data Schema].ProductionPiecePropertiesDefinition')";
                cmd = new SqlCommand(sql, con);

                int partId = 0;

                if (rbGeneric.Checked == true)
                {
                    var keys = pieceTypeID
                    .Where(pair => pair.Value == "Generic")
                    .Select(pair => pair.Key).ToArray();
                    partId = keys[0];

                    choice = true;
                }
                else if (rbAFP.Checked == true)
                {
                    var keys = pieceTypeID
                    .Where(pair => pair.Value == "AFP")
                    .Select(pair => pair.Key).ToArray();
                    partId = keys[0];

                    choice = true;
                }
                else if (rbATL.Checked == true)
                {
                    var keys = pieceTypeID
                    .Where(pair => pair.Value == "ATL")
                    .Select(pair => pair.Key).ToArray();
                    partId = keys[0];

                    choice = true;
                }

                cmd.CommandText = @"INSERT INTO [Data Schema].ProductionPiecePropertiesDefinition(Name,PartID) 
                SELECT * FROM (SELECT @name AS Name, @partid AS PartID) AS temp 
                WHERE NOT EXISTS 
                (SELECT Name FROM [Data Schema].ProductionPiecePropertiesDefinition WHERE [Data Schema].ProductionPiecePropertiesDefinition.Name = @name)";

                cmd.Parameters.AddWithValue("@name", tbProperty.Text);
                cmd.Parameters.AddWithValue("@partid", partId);
                cmd.ExecuteNonQuery();

                if (choice == true)
                {
                    PartPropFill(partId);
                    MessageBox.Show("Успешно дефиниравте особина.");
                    tbProperty.Text = "";
                    if (rbAFP.Checked || rbATL.Checked || rbGeneric.Checked)
                    {
                        rbAFP.Checked = false;
                        rbATL.Checked = false;
                        rbGeneric.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Селектирајте тип на дел!");
                }
            }

            catch
            {
                MessageBox.Show("Има проблем со внесување на податоците во база!");
                return;
            }
            con.Close();

        }

        private SortedList<string, int> SortListProps()
        {
            SortedList<string, int> sortListProp = new SortedList<string, int>();
            for (int i = 0; i < getPropertiesForPartID.Count; i++)
            {
                if (!sortListProp.ContainsKey(getPropertiesForPartID[i].Name))
                {
                    sortListProp[getPropertiesForPartID[i].Name] = getPropertiesForPartID[i].ID;
                }
                else
                    continue;
            }
            return sortListProp;
        }

        private void UpdateDB(int id, string prop, int value)
        {
            string connString;
            SqlCommand cmd;
            SqlConnection con;
            string sql;
            SortedList<string, int> sort = SortListProps();
            int propId = 0;

            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            try
            {
                for (int i = 0; i < sort.Count; i++)
                {

                    if (prop == sort.Keys[i])
                    {
                        propId = sort.Values[i];
                        break;
                    }

                }
                sql = "IF EXISTS (SELECT [Data Schema].ProductionPiecePropertiesValue.PieceID,[Data Schema].ProductionPiecePropertiesValue.PropertyID " +
                    "from[Data Schema].ProductionPiecePropertiesValue " +
                    "where[Data Schema].ProductionPiecePropertiesValue.PieceID = @id and[Data Schema].ProductionPiecePropertiesValue.PropertyID = @propertiID) " +
                    "UPDATE[Data Schema].ProductionPiecePropertiesValue SET Value = @value " +
                    "where[Data Schema].ProductionPiecePropertiesValue.PieceID = @id and[Data Schema].ProductionPiecePropertiesValue.PropertyID = @propertiID " +
                    "ELSE INSERT INTO[Data Schema].ProductionPiecePropertiesValue(PropertyID, PieceID, Value) values(@propertiID, @id, @value)";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@propertiID", propId);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Има проблем со внесување на податоците во база!");
            }
            con.Close();
        }
        int row;
        private void PiecesPropDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            row = PiecesPropDataGridView.CurrentCell.RowIndex;
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            SettingsFileForm settingsFile = new SettingsFileForm();
            settingsFile.ShowDialog();
        }

        private void btGenerateReport_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm(partIDOfSelectedItem, pieceIDOfSelectedItem, serialNumberOfSelectedItem);
            report.ShowDialog();
        }

        private List<ReportPiece> ReadPieceForReport()
        {
            List<Property> props = new List<Property>();
            piecesForReport.Clear();

            // Povrzuvanje so baza

            string connString;
            SqlCommand cmd;
            SqlConnection con = new SqlConnection();
            SqlDataReader dataReader;
            string sql;

            string choice = "";
            int flag = 0;


            SqlCommand cmd1;
            SqlCommand cmdValue;
            SqlDataReader dataReaderValue;

            connString = Program.connectionString + " MultipleActiveResultSets=true";
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            try
            {
                // Citanje na podatocite od bazata,tabela : Sekoja so join :D
                if (rbSerialNumber.Checked == true)
                {
                    if (String.IsNullOrEmpty(tbSerNum.Text))
                    {
                        MessageBox.Show("Внесете сериски број за пребарување на парче!");
                        return null;
                    }
                    else
                    {
                        choice = " where[Data Schema].ProductionPiece.SerialNumber = @serNum";
                        flag = 1;
                    }
                }

                else if (rbTimeRange.Checked == true)
                {
                    if (dtpTimeRange1.Value == dtpTimeRange1.MinDate || dtpTimeRange2.Value == dtpTimeRange2.MinDate)
                    {
                        MessageBox.Show("Внесете соодветен датум за пребарување на парче!");
                    }
                    else
                    {

                        choice = " where [Data Schema].ProductionPiece.Timestamp > @dtp1 and [Data Schema].ProductionPiece.Timestamp < @dtp2";
                        flag = 2;
                    }
                }
                else if (rbTimeRange.Checked == false && rbSerialNumber.Checked == false)
                {
                    MessageBox.Show("Селектирајте опција според која сакате да пребарувате парче!");
                    return null;
                }

                sql = "select [Data Schema].ProductionPiece.SerialNumber,[Data Schema].ProductionPiece.Timestamp, " +
                    "[Config Schema].Operators.UserName,[Config Schema].UsedMaterialType.UsedMaterialType, " +
                    "[Config Schema].UsedMaterialManufacturer.Name,[Data Schema].ProductionPiece.PartID,[Data Schema].ProductionPiece.ID " +
                    "from[Data Schema].ProductionPiece " +
                    "join[Config Schema].Operators " +
                    "on[Config Schema].Operators.ID = [Data Schema].ProductionPiece.OperatorID " +
                    "join[Data Schema].UsedMaterials " +
                    "on[Data Schema].UsedMaterials.PieceID = [Data Schema].ProductionPiece.ID " +
                    "join[Config Schema].UsedMaterialType " +
                    "on[Data Schema].UsedMaterials.UsedMaterialTypeID = [Config Schema].UsedMaterialType.ID " +
                    "join[Config Schema].UsedMaterialManufacturer " +
                    "on[Config Schema].UsedMaterialManufacturer.ID = [Data Schema].UsedMaterials.ManufacturerID " + choice;
                cmd = new SqlCommand(sql, con);
                if (flag == 1)
                {
                    cmd.Parameters.AddWithValue("@serNum", Convert.ToInt32(tbSerNum.Text));
                }
                else if (flag == 2)
                {
                    cmd.Parameters.AddWithValue("@dtp1", dtpTimeRange1.Value);
                    cmd.Parameters.AddWithValue("@dtp2", dtpTimeRange2.Value);
                }

                dataReader = cmd.ExecuteReader();

                SqlDataReader dataReader1;
                while (dataReader.Read())
                {
                    string userName, material, manufactorer;
                    int sN, pieceId, partId;
                    DateTime date;

                    sN = dataReader.GetInt32(0);
                    date = dataReader.GetDateTime(1);
                    userName = dataReader.GetString(2);
                    material = dataReader.GetString(3);
                    manufactorer = dataReader.GetString(4);
                    partId = dataReader.GetInt32(5);
                    pieceId = dataReader.GetInt32(6);

                    string queryProperty = "select [Data Schema].ProductionPiecePropertiesDefinition.ID," +
                        "[Data Schema].ProductionPiecePropertiesDefinition.Name " +
                        "from[Data Schema].ProductionPiecePropertiesDefinition " +
                        "where[Data Schema].ProductionPiecePropertiesDefinition.PartID = @partId";

                    cmd1 = new SqlCommand(queryProperty, con);
                    cmd1.Parameters.AddWithValue("@partId", partId);

                    dataReader1 = cmd1.ExecuteReader();
                    string property = "";
                    int value = 0;
                    int ID = 0;
                    while (dataReader1.Read())
                    {
                        ID = dataReader1.GetInt32(0);
                        property = dataReader1.GetValue(1).ToString();

                        string queryValue = "select [Data Schema].ProductionPiecePropertiesValue.Value," +
                            "[Data Schema].ProductionPiecePropertiesValue.PropertyID " +
                            "from[Data Schema].ProductionPiecePropertiesValue " +
                            "where[Data Schema].ProductionPiecePropertiesValue.PieceID = @pieceId";

                        cmdValue = new SqlCommand(queryValue, con);
                        cmdValue.Parameters.AddWithValue("@pieceId", pieceId);

                        dataReaderValue = cmdValue.ExecuteReader();

                        int valueOfPieceID = 0;
                        int propertyIDOfPieceID = 0;

                        while (dataReaderValue.Read())
                        {
                            valueOfPieceID = dataReaderValue.GetInt32(0);
                            propertyIDOfPieceID = dataReaderValue.GetInt32(1);

                            if (ID == propertyIDOfPieceID)
                            {
                                value = valueOfPieceID;
                                break;
                            }
                            else
                            {
                                value = 0;
                            }
                        }
                        dataReaderValue.Close();
                        Property p = new Property(ID, property, value);
                        props.Add(p);
                    }
                    dataReader1.Close();

                    ReportPiece rp = new ReportPiece(pieceId, partId, sN, date, material, manufactorer, userName);

                    rp.Properties = props;

                    props = new List<Property>();
                    piecesForReport.Add(rp);
                }
                dataReader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()/*"Има проблем со читање на податоците од база!"*/);
                return null;
            }
            con.Close();
            return piecesForReport;
        }
        private void rbSerialNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSerialNumber.Checked == true)
                tbSerNum.Enabled = true;
            else
                tbSerNum.Enabled = false;
        }

        private void rbTimeRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTimeRange.Checked == true)
            {
                dtpTimeRange1.Enabled = true;
                dtpTimeRange2.Enabled = true;
            }
            else
            {
                dtpTimeRange1.Enabled = false;
                dtpTimeRange2.Enabled = false;
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            listViewReport.Items.Clear();
            List<ReportPiece> pieces = ReadPieceForReport();

            foreach (ReportPiece piece in pieces)
            {
                ListViewItem itm;
                string[] arr = new string[2];
                arr[0] = piece.SerialNumber.ToString();
                arr[1] = piece.Time.ToString();

                itm = new ListViewItem(arr);
                listViewReport.Items.Add(itm);
            }
        }
        int serialNumberOfSelectedItem;
        int partIDOfSelectedItem;
        int pieceIDOfSelectedItem;

        private void listViewReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfSelectedItem;
            if (listViewReport.SelectedItems.Count == 1)
            {
                indexOfSelectedItem = listViewReport.FocusedItem.Index;
            }
            else
            {
                return;
            }

            foreach (ReportPiece p in piecesForReport)
            {
                if (listViewReport.Items[indexOfSelectedItem].SubItems[0].Text == p.SerialNumber.ToString())
                {
                    serialNumberOfSelectedItem = p.SerialNumber;
                    partIDOfSelectedItem = p.PartID;
                    pieceIDOfSelectedItem = p.PieceID;

                    break;
                }
            }
        }

        private void PiecesPropDataGridView_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            PiecesPropDataGridView.Update();
            string nameProp = "";
            int value = 0;
            for (int i = 0; i < PiecesPropDataGridView.RowCount; i++)
            {
                if (i == row)
                {
                    nameProp = PiecesPropDataGridView.Rows[i].Cells[0].Value.ToString();
                    value = Convert.ToInt32(PiecesPropDataGridView.Rows[i].Cells[1].Value.ToString());
                    break;
                }
            }
            if (value >= 0)
            {
                UpdateDB(idPieceProp, nameProp, value);
            }
            else
                MessageBox.Show("Вредноста мора да биде позитивна,поголема од нула.");
        }

        private void getSizeOfDB()
        {
            string size;
            SqlConnection con;
            SqlCommand cmd;
            string sConnectionString = Program.connectionString;
           
            string sizeQuery = @"SELECT      sys.databases.name,
            CONVERT(VARCHAR, SUM(size) * 8 / 1024) + ' MB' AS[TDS]FROM sys.databases 
                JOIN        sys.master_files 
                ON          sys.databases.database_id = sys.master_files.database_id 
                where sys.databases.name = @dataBase
                GROUP BY    sys.databases.name ";


            con = new SqlConnection(sConnectionString);
            try
            {
                con.Open();
            }
            catch
            {
            }

            cmd = new SqlCommand(sizeQuery, con);
            cmd.Parameters.AddWithValue("@dataBase", Program.dataBaseName.ToString());
            cmd.ExecuteNonQuery();
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            size = dataReader.GetString(1);
            dataReader.Close();

            con.Close();

            tbSizeOfDB.Text = size;
        }

        private void btBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;

                string conString = Program.connectionString;
                con = new SqlConnection(conString);
                con.Open();

                if (string.IsNullOrEmpty(cmbDataBaseNames.Text))
                {
                    MessageBox.Show("Името на серверот и дата базата не смеат да бидат празни.");
                    return;
                }
                else
                {

                    sfdBackUpDB.FileName = cmbDataBaseNames.Text;
                    sfdBackUpDB.ShowDialog();
                    string s = null;
                    s = sfdBackUpDB.FileName;
                    if (sfdBackUpDB.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    string query = "Backup database " + cmbDataBaseNames.Text + " to disk='" + s + "'";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно ги зачувавте податоците од избраната дата база.");
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Неуспешно ги зачувавте податоците од избраната дата база.");
                return;
            }

        }

        private void buttonDBProject_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (string.IsNullOrEmpty(cmbDBForProject.Text))
                    {
                        MessageBox.Show("Изберете една од дата базите кои сакате да ги користите!");
                        return;
                    }
                }
                catch
                {
                }
                Settings settings = new Settings();
                settings.DataBaseName = cmbDBForProject.Text;
                settings.DataBaseServerName = Program.serverName;


                settings.SaveInXml(settings, "DataBaseInfo.xml");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Има проблем со поврзување со дата база!");
            }
        }

        private void btCreateNewDataBase_Click(object sender, EventArgs e)
        {
            string script = File.ReadAllText(@"C:\Users\leticijah\Desktop\Zadaca2\scriptZadaca2.sql");

            List<string> allDataBases = new List<string>();
            try
            {
                SqlConnection con;
                SqlCommand cmdScript;
                SqlCommand cmdCreate;
                SqlCommand cmdReadAllDB;
                SqlCommand cmdCopy;
                SqlDataReader datareader;

                string conString = Program.connectionString;
                con = new SqlConnection(conString);
                con.Open();
                if (string.IsNullOrEmpty(tbNewDBName.Text))
                {
                    MessageBox.Show("Зададете име на датабазата.");
                    return;
                }

                string queryDataBases = "USE master;  GO SELECT name FROM sys.databases; GO ";
                string[] commands = queryDataBases.Split(
                new string[] { "GO\r\n", "GO ", "GO\t" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string c in commands)
                {
                    cmdReadAllDB = new SqlCommand(c, con);
                    datareader = cmdReadAllDB.ExecuteReader();
                    while (datareader.Read())
                    {
                        allDataBases.Add(datareader.GetString(0));
                    }
                    datareader.Close();
                }
                if (allDataBases.Contains(tbNewDBName.Text))
                {
                    MessageBox.Show("Внесовте веќе постоечко име на дата базата.");
                    return;
                }
                else
                {
                    string dbName = tbNewDBName.Text;
                    string queryCreateDataBase = "CREATE DATABASE " + dbName + ";";

                    cmdCreate = new SqlCommand(queryCreateDataBase, con);
                    cmdCreate.Parameters.AddWithValue("@databaseName", tbNewDBName.Text);
                    cmdCreate.ExecuteNonQuery();

                    script = script.Replace("ProductionDB", tbNewDBName.Text);

                    string[] scriptCmds = script.Split(
               new string[] { "GO\r\n", "GO ", "GO\t" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string c in scriptCmds)
                    {
                        cmdScript = new SqlCommand(c, con);
                        cmdScript.ExecuteNonQuery();
                    }

                    string copyQuery = File.ReadAllText(@"C:\Users\leticijah\Desktop\Zadaca2\copyScript.txt");
                    copyQuery = copyQuery.Replace("Test", tbNewDBName.Text);

                    cmdCopy = new SqlCommand(copyQuery, con);
                    cmdCopy.ExecuteNonQuery();


                }

                MessageBox.Show("Успешно ја креиравте дата базата.");
                con.Close();
            }
            catch
            {
                MessageBox.Show(" Има проблем со креирање на базата.Обидете се повторно.");
                    return;
            }

        }

        private void btMagnifyingGlass_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int serialNum = random.Next(0, 1000);

            bool goIma = existSerialNum(serialNum);

            if (goIma == true)
            {
                MessageBox.Show("Проблем со пронајдување на сериски број!");
            }
            else
            {
                tbSerialNum.Text = serialNum.ToString();
            }
        }

        private void btDefinePiece_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connString;
                SqlCommand cmd;
                SqlConnection con;
                SqlDataReader dataReader;
                string sql;

                if (String.IsNullOrEmpty(tbSerialNum.Text) || String.IsNullOrEmpty(cbMaterialType.Text) || String.IsNullOrEmpty(cbTypeP.Text) || String.IsNullOrEmpty(tbProducedByP.Text))
                {
                    MessageBox.Show("Не ги оставајте полињата празни!");
                    return;
                }

                string pieceType;
                int serialNum;

                pieceType = cbTypeP.Text;


                serialNum = Convert.ToInt32(tbSerialNum.Text);

                if (existSerialNum(serialNum))
                {
                    MessageBox.Show("Внесовте веќе постоечки сериски број!Обидете се повторно!");
                    tbSerialNum.Text = "";
                    return;
                }

                // Povrzuvanje so baza

                connString = Program.connectionString;
                con = new SqlConnection(connString);
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Проблем со поврзување со базата!");
                    return;
                }

                try
                {
                    // Citanje na podatocite od SortedList pieceType

                    int id = 0;
                    foreach (var kvp in pieceTypeID)
                    {
                        id = 0;
                        if (pieceTypeID.ContainsValue(pieceType))
                        {
                            int i = pieceTypeID.IndexOfValue(pieceType);
                            id = pieceTypeID.Keys[i];
                            break;
                        }
                    }

                    // Citanje na podatocite od SortedList operatorsID

                    int idOperator = 0;
                    foreach (var kvp in operatorsID)
                    {
                        idOperator = 0;
                        if (operatorsID.ContainsValue(nameTransfer))
                        {
                            int i = operatorsID.IndexOfValue(nameTransfer);
                            idOperator = operatorsID.Keys[i];
                            break;
                        }
                    }

                    DateTime date = DateTime.Now;


                    Piece piece = new Piece(serialNum, id, idOperator, date);
                    WriteDataPToSQL(piece);

                    // Update na SortedList
                    partId = PartIdRead();

                    string material, producer;

                    material = cbMaterialType.Text;
                    producer = tbProducedByP.Text;

                    // Vnesuvanje na producer vo bazata,tabela : UsedMaterialManufacturer

                    sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Data Schema].UsedMaterialManufacturer')";

                    cmd = new SqlCommand(sql, con);


                    cmd.CommandText = @"INSERT INTO [Config Schema].UsedMaterialManufacturer (Name) VALUES (@name)";

                    cmd.Parameters.AddWithValue("@name", producer);

                    cmd.ExecuteNonQuery();


                    // Citanje na podatocite od bazata,tabela : UsedMaterialManufacturer

                    sql = "Select ID FROM [Config Schema].UsedMaterialManufacturer where Name = @producer";

                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@producer", producer);

                    dataReader = cmd.ExecuteReader();

                    dataReader.Read();

                    int idProducer;
                    idProducer = Convert.ToInt32(dataReader.GetValue(0).ToString());

                    dataReader.Close();

                    // Citanje na podatocite od SortedList usedMaterial

                    int idMaterial = 0;
                    foreach (var kvp in usedMaterial)
                    {
                        idMaterial = 0;
                        if (usedMaterial.ContainsValue(material))
                        {
                            int i = usedMaterial.IndexOfValue(material);
                            idMaterial = usedMaterial.Keys[i];
                            break;
                        }
                    }

                    // Citanje na podatocite od SortedList partId 

                    int idPiece = 0;
                    foreach (var kvp in partId)
                    {
                        idPiece = 0;
                        if (partId.ContainsValue(serialNum))
                        {
                            int i = partId.IndexOfValue(serialNum);
                            idPiece = partId.Keys[i];
                            break;
                        }
                    }

                    // Vnesuvanje na podatocite vo bazata,tabela :  UsedMaterials

                    sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Data Schema].UsedMaterials')";

                    cmd = new SqlCommand(sql, con);


                    cmd.CommandText = @"INSERT INTO [Data Schema].UsedMaterials (UsedMaterialTypeID,ManufacturerID,PieceID) VALUES (@materialID, @manufacturerID, @pieceID)";

                    cmd.Parameters.AddWithValue("@materialID", idMaterial);
                    cmd.Parameters.AddWithValue("@manufacturerID", idProducer);
                    cmd.Parameters.AddWithValue("@pieceID", idPiece);
                    cmd.ExecuteNonQuery();


                    // Vnesuvanje na podatocite vo ListViewPieces

                    StringUsedMaterials usedMaterials = new StringUsedMaterials(pieceType, material, producer, idPiece.ToString());
                    Piece piece1 = new Piece(serialNum, usedMaterials);


                    ListViewItem item;
                    string[] arr = new string[4];

                    arr[0] = piece1.serialNum.ToString();
                    arr[1] = piece1.stringUsedMaterials.Type.ToString();
                    arr[2] = piece1.stringUsedMaterials.MaterialTypeId.ToString();
                    arr[3] = piece1.stringUsedMaterials.ManufacturerId.ToString();

                    item = new ListViewItem(arr);
                    listViewPieces.Items.Add(item);

                    MessageBox.Show("Успешно дефиниравте парче од машински дел!");
                    cbMaterialType.Text = "";
                    cbTypeP.Text = "";
                    tbProducedByP.Text = "";
                    tbSerialNum.Text = "";
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Има проблем со внесување на податоците во база!");
                }

            }
            catch
            {
                MessageBox.Show("Има проблем со конекцијата со базата!");
            }
        }

        private void btMagnifyingGlass_MouseHover_1(object sender, EventArgs e)
        {
            labelMagnifyingGlass.Show();
        }

        private void btMagnifyingGlass_MouseLeave_1(object sender, EventArgs e)
        {
            labelMagnifyingGlass.Hide();
        }

        private void cmbDataBaseFill()
        {
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                string sConnectionString = Program.connectionString;
                con = new SqlConnection(sConnectionString);

                con.Open();

                string queryDB = "SELECT name FROM master.dbo.sysdatabases";
                cmd = new SqlCommand(queryDB, con);
               
                cmd.ExecuteNonQuery();
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cmbDataBaseNames.Items.Add(dataReader.GetString(0));
                    cmbDBForProject.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch
            {
                return; 
            }
        }
    }
}