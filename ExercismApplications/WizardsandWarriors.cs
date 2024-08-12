using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public class WizardsandWarriors
    {
        abstract class Character
        {
            protected Character(string characterType){}

            public abstract int DamagePoints(Character target);

            public virtual bool Vulnerable()
            {
                return false;
            }

            public override string ToString()
            {
                return $"Character is a";
            }
        }

        class Warrior : Character
        {
            public Warrior() : base("Warrior")
            {
            }

            public override string ToString()
            {
                return $"{base.ToString()} Warrior";
            }

            public override int DamagePoints(Character target)
            {
                if (target.Vulnerable())
                {
                    return 10;
                }
                return 6;
            }
        }

        class Wizard : Character
        {
            private bool spellInAdvance = false;
            public Wizard() : base("Wizard")
            {
            }

            public override string ToString()
            {
                return $"{base.ToString()} Wizard";
            }

            public override bool Vulnerable()
            {
                if (!spellInAdvance)
                {
                    return true;
                }
                return false;
            }

            public override int DamagePoints(Character target)
            {
                if (!spellInAdvance)
                {
                    return 3;
                }
                return 12;
            }

            public bool PrepareSpell()
            {
                return spellInAdvance = true;
            }
        }
    }
}

//Instructions
//In this exercise you're playing a role-playing game named "Wizard and Warriors,"
//which allows you to play as either a Wizard or a Warrior.
//There are different rules for Warriors and Wizards to determine how much damage points they deal.
//For a Warrior, these are the rules:
//Deal 6 points of damage if the character they are attacking is not vulnerable
//Deal 10 points of damage if the character they are attacking is vulnerable
//For a Wizard, these are the rules:
//Deal 12 points of damage if the Wizard prepared a spell in advance
//Deal 3 points of damage if the Wizard did not prepare a spell in advance
//In general, characters are never vulnerable. However, Wizards are vulnerable if they haven't prepared a spell.
//You have six tasks that work with Warriors and Wizard characters.