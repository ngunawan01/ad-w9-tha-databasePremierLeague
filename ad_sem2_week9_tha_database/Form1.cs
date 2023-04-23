using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ad_sem2_week9_tha_database
{
    public partial class Form1 : Form
    {
        DataTable dtTeam = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtLengkapPlayer = new DataTable();
        DataTable dtStatistics = new DataTable();
        DataTable dtMatchId = new DataTable();
        DataTable dtMatchDetails = new DataTable();
        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=Coconut23;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public Form1()
        {
            InitializeComponent();
            //sqlQuery = "SELECT player_name, team_name, playing_pos, weight, height  FROM premier_league.player p, premier_league.team WHERE p.team_id = team.team_id and ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            // isi data table nama team yang diberi nama dtTeam
            dtTeam = new DataTable();
            sqlQuery = "SELECT team_id, team_name from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            // update isi combobox dari data table dtTeam 
            comboBoxTeam.DataSource = dtTeam;
            comboBoxTeam.DisplayMember = "team_name";
            comboBoxTeam.ValueMember = "team_id";
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

            // isi data table nama team yang diberi nama dtTeam
            dtTeam = new DataTable();
            sqlQuery = "SELECT team_id, team_name from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            // update isi combobox dari data table dtTeam 
            comboBoxTeam2.DataSource = dtTeam;
            comboBoxTeam2.DisplayMember = "team_name";
            comboBoxTeam2.ValueMember = "team_id";

        }

        private void comboBoxTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // isi data table match id yang diberi nama dtMatchId
            dtMatchId = new DataTable();
            sqlQuery = $"select match_id from `match` where team_home = '{comboBoxTeam2.SelectedValue.ToString()}' or team_away = '{comboBoxTeam2.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchId);

            // update isi combo box match id
            comboBoxMatch2.DataSource = dtMatchId;
            comboBoxMatch2.DisplayMember = "match_id";
            comboBoxMatch2.ValueMember = "match_id";
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // isi data table nama Player yang diberi nama dtPlayer
            dtPlayer = new DataTable();
            sqlQuery = $"SELECT player_name, player_id from player WHERE team_id = '{comboBoxTeam.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            // update isi combobox dari data table dtPlayer
            comboBoxPlayer.DataSource = dtPlayer;
            comboBoxPlayer.DisplayMember = "player_name";
            comboBoxPlayer.ValueMember = "player_id";
        }

        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // isi data table data lengkap para player yang diberi nama dtLengkapPlayer
            dtLengkapPlayer = new DataTable();
            sqlQuery = $"select t.team_name, p.player_name, p.playing_pos, n.nation from team t, player p, nationality n WHERE t.team_id = p.team_id and p.nationality_id = n.nationality_id and t.team_id = '{comboBoxTeam.SelectedValue.ToString()}' and p.player_id = '{comboBoxPlayer.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLengkapPlayer);
            
            // update label untuk menampilkan data
            labelAnswerPlayerTeam.Text = dtLengkapPlayer.Rows[0][0].ToString();
            labelAnswerPlayerName.Text = dtLengkapPlayer.Rows[0][1].ToString();
            labelAnswerPosition.Text = dtLengkapPlayer.Rows[0][2].ToString();
            labelAnswerNationality.Text = dtLengkapPlayer.Rows[0][3].ToString();
            labelAnswerPlayingPos.Text = dtLengkapPlayer.Rows[0][2].ToString();

            // isi data table statistik para player yang diberi nama dtStatistics
            dtStatistics = new DataTable();
            sqlQuery = $"select d.`type` from dmatch d where d.team_id = '{comboBoxTeam.SelectedValue.ToString()}' and d.player_id = '{comboBoxPlayer.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStatistics);

            // for loop untuk menentukan jumlah red card, goals, dan penalty missed
            int crCounter = 0;
            int goCounter = 0;
            int pmCounter = 0;
            int cyCounter = 0;

            foreach(DataRow dtRow in dtStatistics.Rows)
            {
                if (dtRow[0].ToString() == "CR")
                {
                    crCounter++;
                }
                else if (dtRow[0].ToString() == "GO")
                {
                    goCounter++;
                }
                else if (dtRow[0].ToString() == "PM")
                {
                    pmCounter++;
                }
                else if (dtRow[0].ToString() == "CY")
                {
                    cyCounter++;
                }
            }

            // update label untuk menampilkan data
            labelAnswerRedCards.Text = crCounter.ToString();
            labelAnswerGoalsScored.Text = goCounter.ToString();
            labelAnswerPenaltyMissed.Text = pmCounter.ToString();
            labelAnswerYellowCard.Text = cyCounter.ToString();

        }

        private void comboBoxMatch2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // isi data table data lengkap para player yang diberi nama dtLengkapPlayer
            dtMatchDetails = new DataTable();
            sqlQuery = $"select d.match_id, d.`minute`, t.team_name, p.player_name,  if(d.`type`='GO', \"GOAL SCORED\", if(d.`type`='CR', \"RED CARD\", if(d.`type`='PM', \"PENALTY MISSED\", if(d.`type`='CY', \"YELLOW CARD\", if(d.`type`='GW', \"OWN GOAL\", \"PENALTY GOAL\" ))))) as 'TYPE' from dmatch d, team t, player p where t.team_id = p.team_id and t.team_id = d.team_id and p.player_id = d.player_id and d.match_id = '{comboBoxMatch2.SelectedValue.ToString()}' order by 1 asc;;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchDetails);

            // update dgv
            dataGridView1.DataSource = dtMatchDetails;
        }
    }
}
