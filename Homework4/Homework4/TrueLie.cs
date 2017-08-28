using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TrueLie
    {
        public static int QuestionCount(string fileName)
        {
            var count = 0;
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    count++;
                }
            }
            return count;
        }
        
        public static string GetAnswer()
        {
            string answer;
            do
            {
                answer = UiConsole.GetString();
            } while (answer != "Верю" && answer != "Не верю");
            return answer;
        }

        public static void Game()
        {
            var questionNum = 5;
            int[] number= new int[questionNum];
            var check=false;
            var num=0;
            var count = 0;
            string fileName = "TrueLie.txt";
            var questionCount = QuestionCount(fileName);
            if (questionCount >= questionNum)
            {
                UiConsole.PrintLine("Игра \"ВЕРЮ-НЕ ВЕРЮ!\"\nВам зададут три вопроса и вам надо ответить \"Верю\" или \"Не верю\". Проверим вашу эрудицию и интуицию!");
                StrMass question = new StrMass(fileName, questionCount, 2);
                Random random = new Random();
                for (int i = 0; i < questionNum; i++)
                {
                    do
                    {
                        check = false;
                        num = random.Next(questionCount);
                        for (int j = 0; j < i + 1; j++)
                        {
                            if (num == number[j])
                            {
                                check = true;
                                break;
                            }
                        }
                    } while (check);
                    number[i] = num;
                    UiConsole.PrintLine($"Вопрос {i + 1}: {question[number[i], 0]}");
                    if (question[number[i], 1] == GetAnswer())
                    {
                        count++;
                    }
                   
                }
                UiConsole.PrintLine($"Правильных ответов: { count}");
            }
            else
            {
                UiConsole.PrintLine("Программа знает слишком мало фактов. Сыграть не получится. ='(");
            }
        }
    }


}
