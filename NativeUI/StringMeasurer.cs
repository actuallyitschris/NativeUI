using GTA;
using GTA.Native;

namespace NativeUI
{
    public static class StringMeasurer
    {
        public static float MeasureString(string input, Font font, float scale)
        {
            Function.Call(Hash._0x521FB041D93DD0E4, "STRING");  // _BEGIN_TEXT_COMMAND_LINE_COUNT
            Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, input);  // ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME
            Function.Call(Hash.SET_TEXT_FONT, (int)font);
            Function.Call(Hash.SET_TEXT_SCALE, 1.0f, scale);
            return Function.Call<float>(Hash._0x9040DFB09BE75706, .3f, 1);  // _GET_TEXT_SCREEN_LINE_COUNT
        }
    }
}
