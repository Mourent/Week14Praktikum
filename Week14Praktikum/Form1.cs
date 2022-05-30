using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Week14Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtTopScore = new DataTable();
        DataTable dtWorstDiscipline = new DataTable();
        DataTable dtMatch = new DataTable();
        int posisiTeam = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            isiData(0);

        }

        public void isiData(int posisi)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, '(', n.nation, ')'), concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ')') from team t, manager m, nationality n where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            labelOutputTeam.Text = dtTeam.Rows[posisi][0].ToString();
            labelOutputManager.Text = dtTeam.Rows[posisi][1].ToString();
            labelOuputStadium.Text = dtTeam.Rows[posisi][2].ToString();

            DataTable dtTopScore = new DataTable();
            DataTable dtWorstDiscipline = new DataTable();
            DataTable dtMatch = new DataTable();

            sqlQuery = "select concat(p.player_name, ' ', sum(if(dm.type = 'GO' or dm.type = 'GP',1,0)), ' (', sum(if(dm.type = 'GP',1,0)), ')') from player p, team t, dmatch dm where t.team_name = '" + dtTeam.Rows[posisi][0].ToString() + "' and t.team_id = p.team_id and p.player_id = dm.player_id group by p.player_name order by sum(if(dm.type = 'GO' or dm.type = 'GP',1,0)) desc limit 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopScore);
            labelOutputTS.Text = dtTopScore.Rows[0][0].ToString();

            sqlQuery = "select concat(p.player_name, ', ', sum(if(dm.type = 'CY',1,0)), ' Yellow Card and ', sum(if(dm.type = 'CR',1,0)), ' Red Card') from player p, team t, dmatch dm where t.team_name = '" + dtTeam.Rows[posisi][0].ToString() + "' and t.team_id = p.team_id and p.player_id = dm.player_id group by p.player_name order by sum(if(dm.type = 'CY',1,if(dm.type = 'CR',3,0))) desc limit 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorstDiscipline);
            labelOutputWD.Text = dtWorstDiscipline.Rows[0][0].ToString();

            sqlQuery = "select date_format(m.match_date, '%d/%m/%Y') as 'match_date', if(m.team_home = t.team_id,'HOME',if(m.team_away = t.team_id,'AWAY', ' ')) as 'Home/Away', if(m.team_home = t.team_id, concat('vs ', t2.team_name), concat('vs ',t3.team_name)) as 'Lawan', concat(m.goal_home, ' - ', m.goal_away) as 'Score' from `match` m, team t, team t2, team t3 where m.team_home = t3.team_id and m.team_away = t2.team_id and t.team_name = '" + dtTeam.Rows[posisi][0].ToString() + "' and (m.team_home = t.team_id or m.team_away = t.team_id) order by m.match_date desc limit 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dgvMatch.DataSource = dtMatch;
            

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            isiData(0);
            posisiTeam = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (posisiTeam == 0)
            {
                MessageBox.Show("Data Pertama");
            }
            else
                isiData(posisiTeam - 1);
            posisiTeam--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posisiTeam == dtTeam.Rows.Count -1)
            {
                MessageBox.Show("Data Terakhir");
            }
            else
                isiData(posisiTeam + 1);
            posisiTeam++;
        }

        private void btnKanan_Click(object sender, EventArgs e)
        {
            isiData(dtTeam.Rows.Count - 1);
            posisiTeam = dtTeam.Rows.Count - 1;
        }
    }
}
