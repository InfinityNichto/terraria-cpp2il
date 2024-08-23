using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	// Token: 0x0200038C RID: 908
	[global::Cpp2ILInjected.Token(Token = "0x2000527")]
	public abstract class AchievementsSocialModule : ISocialModule
	{
		// Token: 0x06002D5B RID: 11611
		[global::Cpp2ILInjected.Token(Token = "0x60031B4")]
		public abstract void Initialize();

		// Token: 0x06002D5C RID: 11612
		[global::Cpp2ILInjected.Token(Token = "0x60031B5")]
		public abstract void Shutdown();

		// Token: 0x06002D5D RID: 11613
		[global::Cpp2ILInjected.Token(Token = "0x60031B6")]
		public abstract byte[] GetEncryptionKey();

		// Token: 0x06002D5E RID: 11614
		[global::Cpp2ILInjected.Token(Token = "0x60031B7")]
		public abstract string GetSavePath();

		// Token: 0x06002D5F RID: 11615
		[global::Cpp2ILInjected.Token(Token = "0x60031B8")]
		public abstract void UpdateIntStat(string name, int value);

		// Token: 0x06002D60 RID: 11616
		[global::Cpp2ILInjected.Token(Token = "0x60031B9")]
		public abstract void UpdateFloatStat(string name, float value);

		// Token: 0x06002D61 RID: 11617
		[global::Cpp2ILInjected.Token(Token = "0x60031BA")]
		public abstract void CompleteAchievement(string name);

		// Token: 0x06002D62 RID: 11618
		[global::Cpp2ILInjected.Token(Token = "0x60031BB")]
		public abstract bool IsAchievementCompleted(string name);

		// Token: 0x06002D63 RID: 11619
		[global::Cpp2ILInjected.Token(Token = "0x60031BC")]
		public abstract void StoreStats();

		// Token: 0x06002D64 RID: 11620 RVA: 0x0002A21B File Offset: 0x0002841B
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
