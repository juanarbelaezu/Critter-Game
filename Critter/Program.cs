using System;

namespace Critter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Play();

            void Play()
            {
                if (player1.Critter != null && player2.Critter != null)
                {
                    Battle();
                }
            }


            void Battle()
            {
                Critter pl1critter = player1.Critter[0];
                Critter pl2critter = player2.Critter[0];
                float damageVal;

                if(pl1critter.BaseSpeed > pl2critter.BaseSpeed)
                {
                    if(pl1critter.Skill.SupportSkill == false)
                    {
                        Critter1atk();
                    }
                    else if (pl1critter.Skill.SupportSkill == true)
                    {
                        SupSkillpl1();
                    }
                }
                else if(pl2critter.BaseSpeed > pl1critter.BaseSpeed)
                {
                    if (pl2critter.Skill.SupportSkill == false)
                    {
                        Critter2atk();
                    }
                    else if(pl2critter.Skill.SupportSkill == true)
                    {
                        SupSkillpl2();
                    }
                }

                void Critter1atk()
                {
                    if(pl2critter.Hp > 0)
                    {
                        if (pl1critter.Affinitycritter == pl2critter.Affinitycritter || pl1critter.Affinitycritter == "Wind" && pl2critter.Affinitycritter == "Earth" || pl1critter.Affinitycritter == "Water" && pl2critter.Affinitycritter == "Fire")
                        {
                            damageVal = (pl1critter.Attack + pl1critter.Skill.Power) * 0.5f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 2" + damageVal);
                            if (pl2critter.Skill.SupportSkill == false)
                            {
                                Critter2atk();
                            }
                            else if (pl2critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl2();
                            }
                        }
                        else if (pl1critter.Affinitycritter == "Dark" && pl2critter.Affinitycritter == "Light" || pl1critter.Affinitycritter == "Light" && pl2critter.Affinitycritter == "Dark" || pl1critter.Affinitycritter == "Fire" && pl2critter.Affinitycritter == "Water" || pl1critter.Affinitycritter == "Water" && pl2critter.Affinitycritter == "Wind" || pl1critter.Affinitycritter == "Earth" && pl2critter.Affinitycritter == "Wind")
                        {
                            damageVal = (pl1critter.Attack + pl1critter.Skill.Power) * 2f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 2" + damageVal);
                            if (pl2critter.Skill.SupportSkill == false)
                            {
                                Critter2atk();
                            }
                            else if (pl2critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl2();
                            }
                        }
                        else if (pl1critter.Affinitycritter == "Fire" && pl2critter.Affinitycritter == "Earth")
                        {
                            damageVal = (pl1critter.Attack + pl1critter.Skill.Power) * 0f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 2" + damageVal);
                            if (pl2critter.Skill.SupportSkill == false)
                            {
                                Critter2atk();
                            }
                            else if (pl2critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl2();
                            }
                        }
                        else
                        {
                            damageVal = (pl1critter.Attack + pl1critter.Skill.Power) * 1f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 2" + damageVal);
                            if (pl2critter.Skill.SupportSkill == false)
                            {
                                Critter2atk();
                            }
                            else if (pl2critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl2();
                            }
                        }
                    }
                    else if(pl2critter.Hp <= 0)
                    {
                        player1.Critter.Add(pl2critter);
                        player2.Critter.Remove(player2.Critter[0]);
                        Console.WriteLine("Player 1 wins");
                        Play();
                    }
                    
                }

                void Critter2atk()
                {
                    
                    if (pl1critter.Hp > 0)
                    {
                        if (pl2critter.Affinitycritter == pl1critter.Affinitycritter || pl2critter.Affinitycritter == "Wind" && pl1critter.Affinitycritter == "Earth" || pl2critter.Affinitycritter == "Water" && pl1critter.Affinitycritter == "Fire")
                        {
                            damageVal = (pl2critter.Attack + pl2critter.Skill.Power) * 0.5f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 1" + damageVal);
                            if (pl1critter.Skill.SupportSkill == false)
                            {
                                Critter1atk();
                            }
                            else if (pl1critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl1();
                            }
                        }
                        else if (pl2critter.Affinitycritter == "Dark" && pl1critter.Affinitycritter == "Light" || pl2critter.Affinitycritter == "Light" && pl1critter.Affinitycritter == "Dark" || pl2critter.Affinitycritter == "Fire" && pl1critter.Affinitycritter == "Water" || pl2critter.Affinitycritter == "Water" && pl1critter.Affinitycritter == "Wind" || pl2critter.Affinitycritter == "Earth" && pl1critter.Affinitycritter == "Wind")
                        {
                            damageVal = (pl2critter.Attack + pl2critter.Skill.Power) * 2f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 1" + damageVal);
                            if (pl1critter.Skill.SupportSkill == false)
                            {
                                Critter1atk();
                            }
                            else if (pl1critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl1();
                            }
                        }
                        else if (pl2critter.Affinitycritter == "Fire" && pl1critter.Affinitycritter == "Earth")
                        {
                            damageVal = (pl2critter.Attack + pl2critter.Skill.Power) * 0f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 1" + damageVal);
                            if (pl1critter.Skill.SupportSkill == false)
                            {
                                Critter1atk();
                            }
                            else if (pl1critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl1();
                            }
                        }
                        else
                        {
                            damageVal = (pl2critter.Attack + pl2critter.Skill.Power) * 1f;
                            pl2critter.Hp -= damageVal;
                            Console.WriteLine("Damage to player 1" + damageVal);
                            if (pl1critter.Skill.SupportSkill == false)
                            {
                                Critter1atk();
                            }
                            else if (pl1critter.Skill.SupportSkill == true)
                            {
                                SupSkillpl1();
                            }
                        }
                    }
                    else if(pl1critter.Hp <= 0)
                    {
                        player2.Critter.Add(pl1critter);
                        player1.Critter.Remove(player1.Critter[0]);
                        Console.WriteLine("Player 2 wins");
                        Play();
                    }
                }

                void SupSkillpl1()
                {
                    if(pl1critter.Skill.Skilltype == 1)
                    {
                        pl1critter.Attack += pl1critter.Attack * 0.2f;
                        //pl1critter.CounterA += 1;
                        Critter1atk();
                    }
                    else if(pl1critter.Skill.Skilltype == 2)
                    {
                        pl1critter.Defense += pl1critter.Defense * 0.2f;
                        //pl1critter.CounterD += 1;
                        Critter1atk();
                    }
                    else if (pl1critter.Skill.Skilltype == 3)
                    {
                        pl2critter.Speed -= pl2critter.Speed * 0.3f;
                        //pl1critter.CounterS +=1;
                        Critter1atk();
                    }
                }

                void SupSkillpl2()
                {
                    if (pl2critter.Skill.Skilltype == 1)
                    {
                        pl2critter.Attack += pl2critter.Attack * 0.2f;
                        //pl2critter.CounterA += 1;
                        Critter2atk();
                    }
                    else if (pl1critter.Skill.Skilltype == 2)
                    {
                        pl2critter.Defense += pl2critter.Defense * 0.2f;
                        //pl2critter.CounterD += 1;
                        Critter2atk();
                    }
                    else if (pl2critter.Skill.Skilltype == 3)
                    {
                        pl1critter.Speed -= pl1critter.Speed * 0.3f;
                        //pl2critter.CounterS +=1;
                        Critter2atk();
                    }
                }
            }
        }
    }
}
