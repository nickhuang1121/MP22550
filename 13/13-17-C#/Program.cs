byte Sound_timer = 10;
if (Sound_timer > 0)
{
    Sound_timer -= 1;
    Console.Beep(440, 50);
}
