using System;
using System.IO;
using Markdig;

namespace MarkdigTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //マークダウンファイルの読み込み
            var md = File.ReadAllText(@"C:\Users\shuhey\Desktop\markdigReadMe.md");

            //HTMLへの変換
            var html = Markdown.ToHtml(md);

            //HTMLファイルの出力
            File.WriteAllText(@"C:\Users\shuhey\Desktop\markdigReadMe.html", html);

            Console.WriteLine(html);

        }
    }
}
