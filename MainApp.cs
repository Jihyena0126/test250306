using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello //Hello라는 namespace를 만듦
{
    //MainApp이라는 클래스를 담는 대괄호. 다른 네임스페이스에 MainApp 클래스를 사용하려면 using Hello;문장을 이용해 Hello 네임스페이스를 참조하거나 클래스가 소속되어 있는 네임스페이스와 클래스의 이름을 붙여줘야함
    internal class MainApp //솔루션 탐객기의 program.cs를 누르고 F2를 누르면 파일 이름 변경 가능(program.cs->MainApp.cs)
    {
        //프로그램 실행이 시작되는 곳
        static void Main(string[] args) //Main() 메소드, 메소드=명령어
        {
            /*if (args.Length == 0) //args는 문자열 배열. args.Length는 배열의 길이. args.Length == 0은 인수가 하나도 없는 경우를 의미. 즉, 프로그램 실행 시 아무런 인수를 입력하지 않았을 때 이 조건이 참
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return; //return;은 현재 실행 중인 메서드(Main 메서드)를 즉시 종료
            }
            Console.WriteLine("Hello, {0}!", args[0]); //{0}는 자리 표시자(placeholder) 로, args[0] 값이 {0} 자리에 삽입됨. =>if문이 실행되어 이 줄은 띄어넘음. 프롬프트에 출력
            */

            /* Console.WriteLine("여러분, 안녕하세요?\n");
             Console.WriteLine("반갑습니다!"); //p.38 연습문제*/

            /*int x; //선언과
            x = 100; //데이터 할당을 별도로 할 수도 있지만
            Console.WriteLine(x);*/

            /*int x = 100; //선언과 초기화를 한번에 할 수도 있음
            Console.WriteLine(x);*/

            /*int a, b, c; //같은 형식의 변수들은 동시에 선언 가능
            int x = 30, y = 40, z = 50; //같은 형식의 변수들을 선언과 초기화를 한번에 하는 것도 가능*/
        }
    }
}
