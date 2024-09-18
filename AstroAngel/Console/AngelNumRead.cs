using static System.Console;

namespace Angel_Numbers;

public class AngelNumRead
{
    public static void ReadAngelNum(int number)
    {
        switch (number)
        {
            case 111:
                WriteLine("That means you are in for new beginnings! Lucky you!");
                WriteLine("A new beginning could be a new career path? A relationship? Who knows!");
                break;
            case 222:
                WriteLine("That means you are in for harmony and balance in your life.");
                WriteLine("This can also mean You need trust and patience");
                WriteLine("Also it can mean that you need to focus on what your heart wants.");
                WriteLine("Maybe you need to focus on your intuition and inner wisdom in certain situations?");
                WriteLine("Or maybe you need to focus on your relationships and partnerships?");
                WriteLine("Or maybe you need to focus on your career and professional life?");
                WriteLine("Maybe you need to focus on your intuition and inner wisdom in certain situations?");
                WriteLine(
                    "There are many ways to interpret this number, but it is up to you to decide what it means for you.");
                break;
            case 333:
                WriteLine("That means you are in for creativity, optimism, and communication in your life");
                WriteLine("This can also mean that you need to focus on your creativity and express yourself more.");
                break;
            case 444:
                WriteLine("That means you are in for stability in your life!");
                WriteLine(
                    "This can also mean that you need to focus on your stability and security in certain situations.");
                WriteLine("Perhaps consider your home life, your career, or your relationships?");
                break;
            case 555:
                WriteLine("That means you are in for positive change, freedom, discovery, and growth!");
                WriteLine("This can also mean that you need to focus on your personal growth and development.");
                WriteLine("Perhaps consider taking up a new hobby, learning a new skill, or traveling to a new place?");
                break;
            case 666:
                WriteLine("That means you need to shift your focus in your life.");
                WriteLine("This can also mean that you need to focus on your thoughts and beliefs.");
                WriteLine("Perhaps consider your mindset, your attitude, or your perspective on certain situations?");
                break;
            case 777:
                WriteLine("That means you are in for change and abundance in your life.");
                WriteLine("This is very lucky! Embrace change, and take in that abundance!");
                WriteLine("Perhaps you should play the lottery?");
                break;
            case 888:
                WriteLine("That means you are in for abundance, and prosperity in your life.");
                WriteLine("This is the time to reap what you've sown, but make sure to use this abundance wisely!");
                break;
            case 999:
                WriteLine("That means you are in for completion and fulfillment in your life.");
                WriteLine("This is the time to wrap up any loose ends, and prepare for a new beginning!");
                break;
        }
    }
}