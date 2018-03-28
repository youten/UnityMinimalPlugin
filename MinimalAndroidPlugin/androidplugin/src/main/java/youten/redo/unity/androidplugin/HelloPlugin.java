package youten.redo.unity.androidplugin;

import com.unity3d.player.UnityPlayer;

public class HelloPlugin {
    // Unity -> Native Plugin
    public static String createGreeting(String gameObjectName, String who) {
        // Native Plugin -> Unity
        // UnitySendMessage(String gameObjectName, String methodName, String message)
        UnityPlayer.UnitySendMessage(gameObjectName, "onHello", "Message from Native Plugin");

        // return String
        return "Hello " + who + "!";
    }
}
