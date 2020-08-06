using System;

namespace Critter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1;
            Player player2;

            void Battle()
            {
                Critter pl1critter = player1.Critter[0];
                Critter pl2critter = player2.Critter[0];
                float damageVal;

                if (pl1critter.Hp == 0)
                {
                    player2.Critter.Add(pl1critter);
                }
                if(pl2critter.Hp == 0)
                {
                    player1.Critter.Add(pl2critter);
                }

                if(pl1critter.BaseSpeed > pl2critter.BaseSpeed)
                {
                    Critter1atk();
                }
                else if(pl2critter.BaseSpeed > pl1critter.BaseSpeed)
                {
                    Critter2atk();
                }

                void Critter1atk();
                {
                    if (pl1critter.Affinitycritter == pl2critter.Affinitycritter || pl1critter.Affinitycritter == "Wind" && pl2critter.Affinitycritter == "Earth" || pl1critter.Affinitycritter == "Water" && pl2critter.Affinitycritter == "Fire")
                    {
                        damageVal = (pl1critter.BaseAttack + pl1critter.Skill.Power) * 0.5f;
                        pl2critter.Hp -= damageVal;
                    }
                    else if(pl1critter.Affinitycritter == "Dark" && pl2critter.Affinitycritter == "Light" || pl1critter.Affinitycritter == "Light" && pl2critter.Affinitycritter == "Dark" || pl1critter.Affinitycritter == "Fire" && pl2critter.Affinitycritter == "Water" || pl1critter.Affinitycritter == "Water" && pl2critter.Affinitycritter == "Wind" || pl1critter.Affinitycritter == "Earth" && pl2critter.Affinitycritter == "Wind")
                    {
                        damageVal = (pl1critter.BaseAttack + pl1critter.Skill.Power) * 2f;
                        pl2critter.Hp -= damageVal;
                    }
                    else if (pl1critter.Affinitycritter == "Fire" && pl2critter.Affinitycritter == "Earth")
                    {
                        damageVal = (pl1critter.BaseAttack + pl1critter.Skill.Power) * 0f;
                        pl2critter.Hp -= damageVal;
                    }
                    else
                    {
                        damageVal = (pl1critter.BaseAttack + pl1critter.Skill.Power) * 1f;
                        pl2critter.Hp -= damageVal;
                    }
                }

                void Critter2atk();
                {
                    if (pl2critter.Affinitycritter == pl1critter.Affinitycritter || pl2critter.Affinitycritter == "Wind" && pl1critter.Affinitycritter == "Earth" || pl2critter.Affinitycritter == "Water" && pl1critter.Affinitycritter == "Fire")
                    {
                        damageVal = (pl2critter.BaseAttack + pl2critter.Skill.Power) * 0.5f;
                        pl2critter.Hp -= damageVal;
                    }
                    else if (pl2critter.Affinitycritter == "Dark" && pl1critter.Affinitycritter == "Light" || pl2critter.Affinitycritter == "Light" && pl1critter.Affinitycritter == "Dark" || pl2critter.Affinitycritter == "Fire" && pl1critter.Affinitycritter == "Water" || pl2critter.Affinitycritter == "Water" && pl1critter.Affinitycritter == "Wind" || pl2critter.Affinitycritter == "Earth" && pl1critter.Affinitycritter == "Wind")
                    {
                        damageVal = (pl2critter.BaseAttack + pl2critter.Skill.Power) * 2f;
                        pl2critter.Hp -= damageVal;
                    }
                    else if (pl2critter.Affinitycritter == "Fire" && pl1critter.Affinitycritter == "Earth")
                    {
                        damageVal = (pl2critter.BaseAttack + pl2critter.Skill.Power) * 0f;
                        pl2critter.Hp -= damageVal;
                    }
                    else
                    {
                        damageVal = (pl2critter.BaseAttack + pl2critter.Skill.Power) * 1f;
                        pl2critter.Hp -= damageVal;
                    }

                    
                }
            }

            
        }
    }
}
