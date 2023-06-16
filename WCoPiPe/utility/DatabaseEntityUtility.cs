using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCoPiPe.utility
{
    internal class DatabaseEntityUtility
    {

        public abstract class Database
        {
            public enum DatabaseType
            {
                [Description("ユーザーデータベース")]
                UserDatabase,

                [Description("可変データベース")]
                VariableDatabase,

                [Description("システムデータベース")]
                SystemDatabase
            }

            public DatabaseType Type { get; set; }
            public abstract int CalculateValue();

            protected int _x;
            public int A
            {
                get { return _x; }
                set
                {
                    if (value < 0 || value > 99)
                        throw new ArgumentOutOfRangeException("X must be between 0 and 99");
                    _x = value;
                }
            }

            protected int _y;
            public int B
            {
                get { return _y; }
                set
                {
                    if (value < 0 || value > 9999)
                        throw new ArgumentOutOfRangeException("Y must be between 0 and 9999");
                    _y = value;
                }
            }

            protected int _z;
            public int C
            {
                get { return _z; }
                set
                {
                    if (value < 0 || value > 99)
                        throw new ArgumentOutOfRangeException("Z must be between 0 and 99");
                    _z = value;
                }
            }
        }

        public class UserDatabase : Database
        {
            public override int CalculateValue()
            {
                return 1000000000 + 1000000 * A + 100 * B + C;
            }
        }

        public class VariableDatabase : Database
        {
            public override int CalculateValue()
            {
                return 1100000000 + 1000000 * A + 100 * B + C;
            }
        }

        public class SystemDatabase : Database
        {
            public override int CalculateValue()
            {
                return 1300000000 + 1000000 * A + 100 * B + C;
            }
        }

        public static Dictionary<Database.DatabaseType, string> DatabaseTypeDescriptions = new Dictionary<Database.DatabaseType, string>
        {
            { Database.DatabaseType.UserDatabase, "ﾕｰｻﾞﾃﾞｰﾀﾍﾞｰｽ タイプA/データB/項目C\n1000000000 (10AABBBBCC)" },
            { Database.DatabaseType.VariableDatabase, "可変ﾃﾞｰﾀﾍﾞｰｽ タイプA/データB/項目C\n1100000000 (11AABBBBCC)" },
            { Database.DatabaseType.SystemDatabase, "システムﾃﾞｰﾀﾍﾞｰｽ タイプA/データB/項目C\n1300000000 (13AABBBBCC)" }
        };
    }
}
