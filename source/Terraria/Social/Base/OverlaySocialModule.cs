using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x200052C")]
	public abstract class OverlaySocialModule : ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031E5")]
		public abstract void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x60031E6")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x60031E7")]
		public abstract bool IsGamepadTextInputActive();

		[global::Cpp2ILInjected.Token(Token = "0x60031E8")]
		public abstract bool ShowGamepadTextInput(string description, uint maxLength, bool multiLine = false, string existingText = "", bool password = false);

		[global::Cpp2ILInjected.Token(Token = "0x60031E9")]
		public abstract string GetGamepadText();

		[global::Cpp2ILInjected.Token(Token = "0x60031EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADD8", Offset = "0x132ADD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected OverlaySocialModule()
		{
			throw null;
		}
	}
}
