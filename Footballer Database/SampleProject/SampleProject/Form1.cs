using Microsoft.EntityFrameworkCore;
using SampleProject.Data;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Footballer footballer = new Footballer();
        Team team = new Team();
        Sponsor sponsor = new Sponsor();
        FootballerSponsor fbsp = new FootballerSponsor();

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextDB = new FootballerDBContext();
            contextDB.Database.EnsureCreated();

            delButton.Enabled = false;
            updButton.Enabled = false;

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (FootballerDBContext FootballerDBContext = new FootballerDBContext())
                {
                    var sponsorCheck = FootballerDBContext.Sponsors.Any(x => x.Name == Sponsor.Text.Trim());
                    var teamCheck = FootballerDBContext.Teams.Any(r => r.Name == teamName.Text.Trim());

                    if (sponsorCheck)
                    {
                        sponsor = FootballerDBContext.Sponsors.FirstOrDefault(z => z.Name == Sponsor.Text);
                        //sponsor.SponsorId = FootballerDBContext.Sponsors.FirstOrDefault(x => x.Name == Sponsor.Text.Trim()).SponsorId;
                        //sponsor.Name = FootballerDBContext.Sponsors.FirstOrDefault(x => x.Name == Sponsor.Text.Trim()).Name;
                    }

                    if (teamCheck)
                    {
                        team = FootballerDBContext.Teams.FirstOrDefault(c => c.Name == teamName.Text);

                    }
                    else
                    {
                        team.Name = teamName.Text.Trim();
                    }

                    sponsor.Name = Sponsor.Text.Trim();

                    footballer.Name = fblName.Text.Trim();
                    footballer.Surname = Surname.Text.Trim();
                    footballer.Team = team;

                    fbsp.Footballer = footballer;
                    fbsp.Sponsor = sponsor;
                    var result = MessageBox.Show("Do you really want to add this record.", "Confirm", MessageBoxButtons.YesNo);


                    if (result == DialogResult.Yes)
                    {
                        FootballerDBContext.Footballers.Add(footballer);
                        if (!teamCheck)
                        {
                            FootballerDBContext.Teams.Add(team);
                        }
                        FootballerDBContext.FootballerSponsor.Add(fbsp);
                        FootballerDBContext.SaveChanges();
                        MessageBox.Show("Record added successfully.");
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Record couldn't added , problem occured.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (var db = new FootballerDBContext())
            {
                try
                {
                    var result = MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {



                        var id = Convert.ToInt32(IDbox.Text);
                        var spnsrid = db.Sponsors.FirstOrDefault(x => x.Name == Sponsor.Text).SponsorId;
                        var teamid = db.Teams.FirstOrDefault(x => x.Name == teamName.Text).TeamId;

                        var team1 = db.Teams.Find(teamid);
                        var spnsr = db.Sponsors.Find(spnsrid);
                        var fotballer = db.Footballers.Find(id);
                        db.Teams.Remove(team1);
                        db.Footballers.Remove(fotballer);
                        db.Sponsors.Remove(spnsr);
                        db.SaveChanges();
                        MessageBox.Show("Successfully deleted.");
                    }
                }
                catch 
                {

                    MessageBox.Show("Deletede terminated. You have to choose record.");
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var contextDB = new FootballerDBContext())
            {
                contextDB.Database.EnsureCreated();
                var neededContext = contextDB.FootballerSponsor.Include(g => g.Footballer).ThenInclude(v => v.Team);

                var retrieveData = neededContext.Select(d => new
                {
                    ID=d.Footballer.FootballerId,
                    Name = d.Footballer.Name,
                    Surname = d.Footballer.Surname,
                    Team = d.Footballer.Team.Name,
                    Sponsor = d.Sponsor.Name,

                });
      
                dataGridView1.DataSource = retrieveData.ToList();
                contextDB.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (var db = new FootballerDBContext())
            {
                var fbsp1 = db.FootballerSponsor.Single(x => x.Footballer.Name == fblName.Text);
                
                    try
                    {
                        var teamCheck = db.Teams.Any(r => r.Name == teamName.Text.Trim());
   
                        var st = (from s in db.Footballers where s.FootballerId == int.Parse(IDbox.Text) select s).First();

                        if (!teamCheck)
                        {
                            st.Team = new Team
                            {
                                Name = teamName.Text.Trim(),

                            };

                        }
                        else
                        {
                            st.Team = db.Teams.FirstOrDefault(c => c.Name == teamName.Text);
                        }


                        MessageBox.Show("Updating performed successfully.");

                    }
                    catch
                    {

                        MessageBox.Show("Updating failed.");
                    }

                    db.SaveChanges();
  
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fblName.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            IDbox.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Surname.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            teamName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Sponsor.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fblName.Enabled = false;
            Surname.Enabled = false;
            IDbox.Enabled = false;

            updButton.Enabled = true;
            delButton.Enabled = true;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fblName.Text = "";
            Surname.Text = "";
            IDbox.Text = "";
            teamName.Text = "";
            Sponsor.Text = "";

            fblName.Enabled = true;
            Surname.Enabled = true;

            updButton.Enabled = false;
            delButton.Enabled = false;

        }
    }
    }

