using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseByteOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunReverseByteOrder();
            Console.ReadLine();
        }

        public static void RunReverseByteOrder()
        {
            var str =
                "嬀儀䌀崀 䴀漀椀 儀甀礀 欀栀愀挀栀 最漀椀 ㄀　㘀㠀 ⠀㈀⸀㔀　　搀⼀瀀⤀ 搀攀 琀愀渀最 渀栀甀渀最 䴀伀一 儀唀䄀 礀 渀最栀椀愀 栀愀渀 渀最愀礀 嘀䄀䰀䔀一吀䤀一䔀 搀愀渀栀 挀栀漀 洀漀琀 渀甀愀 礀攀甀 琀栀甀漀渀最 挀甀愀 洀椀渀栀⸀ 吀甀 挀栀漀椀 儀䌀Ⰰ 漀愀渀 吀䌀㌀ 最甀椀 ㄀㤀㤀 ";

            Func<string, string> reverseByteCode = (input) =>
            {
                var result = new List<byte>();
                foreach (var c in input)
                {
                    var bytes = Encoding.Unicode.GetBytes(c.ToString());
                    result.AddRange(bytes.Reverse());
                }

                return Encoding.Unicode.GetString(result.ToArray());
            };

            var strAfterReverseByte = reverseByteCode(str);
            Console.WriteLine(strAfterReverseByte);
        }
    }
}
