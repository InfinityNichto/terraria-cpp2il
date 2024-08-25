using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000527")]
	public abstract class AchievementsSocialModule : ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031B4")]
		public abstract void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x60031B5")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x60031B6")]
		public abstract byte[] GetEncryptionKey();

		[global::Cpp2ILInjected.Token(Token = "0x60031B7")]
		public abstract string GetSavePath();

		[global::Cpp2ILInjected.Token(Token = "0x60031B8")]
		public abstract void UpdateIntStat(string name, int value);

		[global::Cpp2ILInjected.Token(Token = "0x60031B9")]
		public abstract void UpdateFloatStat(string name, float value);

		[global::Cpp2ILInjected.Token(Token = "0x60031BA")]
		public abstract void CompleteAchievement(string name);

		[global::Cpp2ILInjected.Token(Token = "0x60031BB")]
		public abstract bool IsAchievementCompleted(string name);

		[global::Cpp2ILInjected.Token(Token = "0x60031BC")]
		public abstract void StoreStats();

		[global::Cpp2ILInjected.Token(Token = "0x60031BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A860", Offset = "0x132A860", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AchievementsSocialModule()
		{
			throw null;
		}
	}
}
