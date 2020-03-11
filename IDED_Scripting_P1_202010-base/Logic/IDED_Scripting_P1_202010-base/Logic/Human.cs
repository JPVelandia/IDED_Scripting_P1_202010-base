using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential)
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            Potential = _potential;
            if (Potential < 0)
            {
                Potential = 0;
            }
            else if(Potential > 10)
            {
                Potential = 10;
            }

            //humano que se inicializa como villager 

            if (int.Parse(_unitClass.ToString()) >= 5)
            {
                _unitClass = 0;
                AsignarValores();
            }
            AñadirPotencial();
        }

        // se suma hasta el 10% del ataque y la defensa
        public void AñadirPotencial()
        {
            Attack = Attack + (Attack * (Potential / 100));
            Defense = Defense + (Defense * (Potential / 100));

        }

        //cumplir con todas las condiciones de cambio
        public virtual bool ChangeClass(EUnitClass newClass)
        {
            bool changeable = false; 

            switch (int.Parse(UnitClass.ToString()))
            {
                case 0:
                    changeable = false;
                    break;
                   
                case 1:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 2:
                            changeable = true;
                            break;

                    }
                    break;

                case 2:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 1:
                            changeable = true;
                            break;

                    }
                    break;

                case 3:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 4:
                            changeable = true;
                            break;

                    }
                    break;

                case 4:
                    switch (int.Parse(newClass.ToString()))
                    {
                        default:
                            changeable = false;
                            break;

                        case 3:
                            changeable = true;
                            break;

                    }
                    break;

            }
            return changeable;
        }
    }
}