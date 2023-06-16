using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCoPiPe.utility
{
    public class ValiableEntityUtility
    {
        public static Entity CreateEntity(ValiableEntityUtility.EntityType entityType, int y, int x)
        {
            switch (entityType)
            {
                case ValiableEntityUtility.EntityType.MapEvent:
                    return new MapEvent { Y = y, X = x };
                case ValiableEntityUtility.EntityType.ThisMapEvent:
                    return new ThisMapEvent { X = x };
                case ValiableEntityUtility.EntityType.CommonEvent:
                    return new CommonEvent { Y = y, X = x };
                case ValiableEntityUtility.EntityType.ThisCommonEvent:
                    return new ThisCommonEvent { X = x };
                case ValiableEntityUtility.EntityType.RegularVariable:
                    return new RegularVariable { X = x };
                case ValiableEntityUtility.EntityType.ExtraVariable:
                    return new ExtraVariable { Y = y, X = x };
                case ValiableEntityUtility.EntityType.StringVariable:
                    return new StringVariable { X = x };
                case ValiableEntityUtility.EntityType.RandomValue:
                    return new RandomValue { X = x };
                case ValiableEntityUtility.EntityType.EventCoordinate:
                    return new EventCoordinate { Y = y, X = x };
                case ValiableEntityUtility.EntityType.MainCharacterCoordinate:
                    return new MainCharacterCoordinate { Y = y, X = x };
                case ValiableEntityUtility.EntityType.ThisEventCoordinate:
                    return new ThisEventCoordinate { X = x };
                case ValiableEntityUtility.EntityType.SystemVariable:
                    return new SystemVariable { X = x };
                case ValiableEntityUtility.EntityType.SystemString:
                    return new SystemString { X = x };
                default:
                    throw new ArgumentException($"Invalid EntityType: {entityType}");
            }
        }

        public enum EntityType
        {
            [Description("マップイベント")]
            MapEvent,

            [Description("このマップイベント")]
            ThisMapEvent,

            [Description("コモンイベント")]
            CommonEvent,

            [Description("このコモンイベント")]
            ThisCommonEvent,

            [Description("通常変数")]
            RegularVariable,

            [Description("予備変数")]
            ExtraVariable,

            [Description("文字列変数")]
            StringVariable,

            [Description("ランダム値")]
            RandomValue,

            [Description("システム変数")]
            SystemVariable,

            [Description("イベント座標")]
            EventCoordinate,

            [Description("主人公・仲間の座標")]
            MainCharacterCoordinate,

            [Description("このイベントの座標")]
            ThisEventCoordinate,

            [Description("システム文字列")]
            SystemString,
        }


        public abstract class Entity
        {
            public EntityType Type { get; set; }
            public abstract int CalculateValue();
        }

        public class MapEvent : Entity
        {
            public int Y { get; set; }
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 1000000 + 10 * Y + X;
            }
        }
        public class ThisMapEvent : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 1100000 + X;
            }
        }

        public class CommonEvent : Entity
        {
            public int Y { get; set; }
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 15000000 + 100 * Y + X;
            }
        }

        public class ThisCommonEvent : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 1600000 + X;
            }
        }

        public class RegularVariable : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 2000000 + X;
            }
        }

        public class ExtraVariable : Entity
        {
            public int Y { get; set; }
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 2000000 + 100000 * Y + X;
            }
        }

        public class StringVariable : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 3000000 + X;
            }
        }
        public class RandomValue : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 8000000 + X;
            }
        }
        public class EventCoordinate : Entity
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override int CalculateValue()
            {
                return 9100000 + 10 * Y + X;
            }
        }

        public class MainCharacterCoordinate : Entity
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override int CalculateValue()
            {
                return 9180000 + 10 * Y + X;
            }
        }

        public class ThisEventCoordinate : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 9190000 + X;
            }
        }

        public class SystemVariable : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 9000000 + X;
            }
        }
        public class SystemString : Entity
        {
            public int X { get; set; }

            public override int CalculateValue()
            {
                return 9900000 + X;
            }
        }
        public static Dictionary<EntityType, string> EntityTypeDescriptions = new Dictionary<EntityType, string>
{
    { EntityType.MapEvent, "マップイベントYのセルフ変数X\n1000000+10*Y+X" },
    { EntityType.ThisMapEvent, "このマップイベントのセルフ変数X\n（コモンセルフ変数と間違えやすいので注意！）\n1100000+X" },
    { EntityType.CommonEvent, "コモンEv Y のコモンセルフ変数X\n (X：0-4,10-99通常変数, 5-9文字列)\n15000000+100*Y+X" },
    { EntityType.ThisCommonEvent, "このコモンEvのコモンセルフ変数X\n（マップセルフ変数と間違えやすいので注意！）\n1600000+X" },
    { EntityType.RegularVariable, "通常変数X番\n2000000+X" },
    { EntityType.ExtraVariable, "予備変数YのX番\n（例：2100003＝予備変数1の3番)\n2000000+100000*Y+X" },
    { EntityType.StringVariable, "文字列変数 X番\n3000000+X" },
    { EntityType.RandomValue, "0からXまでの値をランダムに返す\n8000000+X" },
    { EntityType.SystemVariable, "ｼｽﾃﾑ変数 X番\n9000000+X" },
    { EntityType.EventCoordinate, "イベントYの座標を取得or入力\n9100000+10*Y+X" },
    { EntityType.MainCharacterCoordinate, "主人公・仲間の座標などを取得or入力\n9180000+10*Y+X" },
    { EntityType.ThisEventCoordinate, "このイベントの座標などを取得or入力\n9190000+X" },
    { EntityType.SystemString, "システム文字列X番\n9900000+X" },

};

        public static Dictionary<EntityType, (string Label1, string Label2)> EntityTypeLabels = new Dictionary<EntityType, (string Label1, string Label2)>
{
    { EntityType.MapEvent, ("マップイベントY", "セルフ変数X") },
    { EntityType.ThisMapEvent, ("", "このマップイベントの\nセルフ変数X") },
    { EntityType.CommonEvent, ("コモンEv Y", "コモンセルフ変数X") },
    { EntityType.ThisCommonEvent, ("", "このコモンEvの\nコモンセルフ変数X") },
    { EntityType.RegularVariable, ("", "通常変数X番") },
    { EntityType.ExtraVariable, ("予備変数Yの", "X番") },
    { EntityType.StringVariable, ("", "文字列変数 X番") },
    { EntityType.RandomValue, ("", "0からXまでの値") },
    { EntityType.SystemVariable, ("", "システム変数X番") },
    { EntityType.EventCoordinate, ("イベントYの", "座標などを\n取得or入力") },
    { EntityType.MainCharacterCoordinate, ("主人公・仲間の", "座標を取得or入力") },
    { EntityType.ThisEventCoordinate, ("", "このイベントの座標を\n取得or入力") },

    { EntityType.SystemString, ("", "システム文字列X番") },
};
    }
}
