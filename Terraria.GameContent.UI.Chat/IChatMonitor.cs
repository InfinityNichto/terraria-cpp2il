using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F2")]
public interface IChatMonitor
{
	[Cpp2IlInjected.Token(Token = "0x6004581")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NewText(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue);

	[Cpp2IlInjected.Token(Token = "0x6004582")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1);

	[Cpp2IlInjected.Token(Token = "0x6004583")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DrawChat(bool drawingPlayerChat);

	[Cpp2IlInjected.Token(Token = "0x6004584")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x6004585")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Update();

	[Cpp2IlInjected.Token(Token = "0x6004586")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Offset(int linesOffset);

	[Cpp2IlInjected.Token(Token = "0x6004587")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ResetOffset();

	[Cpp2IlInjected.Token(Token = "0x6004588")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnResolutionChange();
}
