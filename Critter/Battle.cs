using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Battle : Program
    {

        Player player1 = new Player();
        Player player2 = new Player();

        void Play()
        {
            if (player1.CritterList != null && player2.CritterList != null)
            {
                Battlef();
            }
            else if(player1.CritterList == null)
            {
                Console.WriteLine("No se puede continuar porque el jugador 1 no tiene una criatura");
            }
            else if(player2.CritterList == null)
            {
                Console.WriteLine("No se puede continuar porque el jugador 2 no tiene una criatura");
            }
        }

        void Battlef()
        {

            Critter pl1critter = player1.CritterList[0];
            Critter pl2critter = player2.CritterList[0];
            float damageVal;

            if (pl1critter.BaseSpeed > pl2critter.BaseSpeed)
            {
                if (pl1critter.Skill.SupportSkill == false)
                {
                    Critter1atk();
                }
                else if (pl1critter.Skill.SupportSkill == true)
                {
                    SupSkillpl1();
                }
            }
            else if (pl2critter.BaseSpeed > pl1critter.BaseSpeed)
            {
                if (pl2critter.Skill.SupportSkill == false)
                {
                    Critter2atk();
                }
                else if (pl2critter.Skill.SupportSkill == true)
                {
                    SupSkillpl2();
                }
            }

            void Critter1atk()
            {
                if (pl2critter.Hp > 0)
                {
                    if (pl1critter.Affinitycritter == pl2critter.Affinitycritter || pl1critter.Affinitycritter == "2" && pl2critter.Affinitycritter == "4" || pl1critter.Affinitycritter == "3" && pl2critter.Affinitycritter == "0")
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
                    else if (pl1critter.Affinitycritter == "5" && pl2critter.Affinitycritter == "6" || pl1critter.Affinitycritter == "6" && pl2critter.Affinitycritter == "5" || pl1critter.Affinitycritter == "0" && pl2critter.Affinitycritter == "3" || pl1critter.Affinitycritter == "3" && pl2critter.Affinitycritter == "2" || pl1critter.Affinitycritter == "4" && pl2critter.Affinitycritter == "2")
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
                    else if (pl1critter.Affinitycritter == "0" && pl2critter.Affinitycritter == "4")
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
                else if (pl2critter.Hp <= 0)
                {
                    player1.CritterList.Add(pl2critter);
                    player2.CritterList.Remove(player2.CritterList[0]);
                    Console.WriteLine("Player 1 wins");
                    Play();
                }

            }

            void Critter2atk()
            {

                if (pl1critter.Hp > 0)
                {
                    if (pl2critter.Affinitycritter == pl1critter.Affinitycritter || pl2critter.Affinitycritter == "2" && pl1critter.Affinitycritter == "4" || pl2critter.Affinitycritter == "3" && pl1critter.Affinitycritter == "0")
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
                    else if (pl2critter.Affinitycritter == "5" && pl1critter.Affinitycritter == "6" || pl2critter.Affinitycritter == "6" && pl1critter.Affinitycritter == "5" || pl2critter.Affinitycritter == "0" && pl1critter.Affinitycritter == "3" || pl2critter.Affinitycritter == "3" && pl1critter.Affinitycritter == "2" || pl2critter.Affinitycritter == "4" && pl1critter.Affinitycritter == "2")
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
                    else if (pl2critter.Affinitycritter == "0" && pl1critter.Affinitycritter == "4")
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
                else if (pl1critter.Hp <= 0)
                {
                    player2.CritterList.Add(pl1critter);
                    player1.CritterList.Remove(player1.CritterList[0]);
                    Console.WriteLine("Player 2 wins");
                    Play();
                }
            }

            void SupSkillpl1()
            {
                if (pl1critter.Skill.Skilltype == 1)
                {
                    if (pl1critter.CounterA > 0)
                    {
                        pl1critter.Attack += pl1critter.Attack * 0.2f;
                        pl1critter.CounterA += 1;
                        Console.WriteLine("Daño aumentado en" + pl1critter.Attack);
                        Critter1atk();
                    }
                    else if (pl1critter.CounterA == 3)
                    {
                        Console.WriteLine("No es posible aumentar mas esta skill");
                        Critter1atk();
                    }
                }
                else if (pl1critter.Skill.Skilltype == 2)
                {
                    if (pl1critter.CounterD > 0)
                    {
                        pl1critter.Defense += pl1critter.Defense * 0.2f;
                        pl1critter.CounterD += 1;
                        Console.WriteLine("Defensa aumentada en" + pl1critter.Defense);
                        Critter1atk();
                    }
                    else if (pl1critter.CounterD == 3)
                    {
                        Console.WriteLine("No es posible aumentar mas esta skill");
                        Critter1atk();
                    }
                }
                else if (pl1critter.Skill.Skilltype == 3)
                {
                    if (pl1critter.CounterS > 0)
                    {
                        pl1critter.Speed += pl1critter.Speed * 0.2f;
                        pl1critter.CounterS += 1;
                        Console.WriteLine("Velocidad aumentada en" + pl1critter.Speed);
                        Critter1atk();
                    }
                    else if (pl1critter.CounterS == 3)
                    {
                        Console.WriteLine("No es posible aumentar mas esta skill");
                        Critter1atk();
                    }
                }
            }

            void SupSkillpl2()
            {
                if (pl2critter.Skill.Skilltype == 1)
                {
                    if (pl2critter.CounterA > 0)
                    {
                        pl2critter.Attack += pl2critter.Attack * 0.2f;
                        pl2critter.CounterA += 1;
                        Console.WriteLine("Daño aumentado en" + pl2critter.Attack);
                        Critter2atk();
                    }
                    else if (pl2critter.CounterA == 3)
                    {
                        Console.WriteLine("No es posible aumentar mas esta skill");
                        Critter2atk();
                    }
                }
                else if (pl2critter.Skill.Skilltype == 2)
                {
                    if (pl2critter.CounterD > 0)
                    {
                        pl2critter.Defense += pl2critter.Defense * 0.2f;
                        pl2critter.CounterD += 1;
                        Console.WriteLine("Defensa aumentada en" + pl2critter.Defense);
                        Critter2atk();
                    }
                    else if (pl2critter.CounterD == 3)
                    {
                        Console.WriteLine("No es posible aumentar mas esta skill");
                        Critter2atk();
                    }
                }
                else if (pl2critter.Skill.Skilltype == 3)
                {
                    if (pl2critter.CounterS > 0)
                    {
                        pl2critter.Speed += pl2critter.Speed * 0.2f;
                        pl2critter.CounterS += 1;
                        Console.WriteLine("Velocidad aumentada en" + pl2critter.Speed);
                        Critter2atk();
                    }
                    else if (pl2critter.CounterS == 3)
                    {
                        Console.WriteLine("No es posible aumentar mas esta skill");
                        Critter2atk();
                    }
                }
            }
        }
    }
}
