using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    public enum EUnitClass
    {
        Villager,
        Squire,
        Soldier,
        Ranger,
        Mage,
        Imp,
        Orc,
        Dragon
    }

    public class Villager : Unit
    {
        public Villager(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Squire : Unit
    {

        public Squire(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Soldier : Unit
    {
        public Soldier(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Ranger : Unit
    {
        public Ranger(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            float newBaseAtk = BaseAtk + BaseAtkAdd;
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Mage : Unit
    {
        public Mage(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            float newBaseAtk = BaseAtk + BaseAtkAdd;
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Imp : Unit
    {
        public Imp(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            float newBaseAtk = BaseAtk + BaseAtkAdd;
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Orc : Unit
    {
        public Orc(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            float newBaseAtk = BaseAtk + BaseAtkAdd;
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }

    public class Dragon : Unit
    {
        public Dragon(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            float newBaseAtk = BaseAtk + BaseAtkAdd;
        }
        public override bool Interact(Unit otherUnit)
        {
            return base.Interact(otherUnit);
        }
    }
}