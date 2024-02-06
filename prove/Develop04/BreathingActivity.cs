public class BreathingActivity : Activity
{
    public BreathingActivity():base(){

    }
    public void Run(){
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetName("Breathing Activity");
        DisplayStartingMessage();
        bool action = true;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while(action){
            Console.Write("Breathe in...   ");
            //Run Animation
            ShowCountDown(4);
            Console.WriteLine("\nBreathe out...\n");

            if(DateTime.Now > futureTime){
                action = false;
            }
        }
    }
}