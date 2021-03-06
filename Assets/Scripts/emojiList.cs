using System;
public class emojiList
{
    public static string[] emojis = new string[] { "1️⃣", "2️⃣", "3️⃣", "4️⃣", // 0, 1, 2, 3
                                                "👤", "👥", // 4, 5
                                                "🔴", "🔵", "🟢", "🟣", // 6, 7, 8, 9  -- red, blue, green, yellow
                                                "😎", "😘", "😠", // 10, 11, 12
                                                "⬅️", "⬆️", "⬇️", "➡️", // 13, 14, 15. 16
                                                "⚔️", "🛡", // 17, 18
                                                "❌", "🅾️" }; // 19, 20

    public static int findEmoji(string emoji)
    {
        return Array.FindIndex(emojis, emo => emo == emoji);
    }
}
