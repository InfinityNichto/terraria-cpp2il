using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	// Token: 0x02000391 RID: 913
	[global::Cpp2ILInjected.Token(Token = "0x200052C")]
	public abstract class OverlaySocialModule : ISocialModule
	{
		// Token: 0x06002D8C RID: 11660
		[global::Cpp2ILInjected.Token(Token = "0x60031E5")]
		public abstract void Initialize();

		// Token: 0x06002D8D RID: 11661
		[global::Cpp2ILInjected.Token(Token = "0x60031E6")]
		public abstract void Shutdown();

		// Token: 0x06002D8E RID: 11662
		[global::Cpp2ILInjected.Token(Token = "0x60031E7")]
		public abstract bool IsGamepadTextInputActive();

		// Token: 0x06002D8F RID: 11663
		[global::Cpp2ILInjected.Token(Token = "0x60031E8")]
		public abstract bool ShowGamepadTextInput(string description, uint maxLength, bool multiLine = false, string existingText = "", bool password = false);

		// Token: 0x06002D90 RID: 11664
		[global::Cpp2ILInjected.Token(Token = "0x60031E9")]
		public abstract string GetGamepadText();

		// Token: 0x06002D91 RID: 11665 RVA: 0x0002A242 File Offset: 0x00028442
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
