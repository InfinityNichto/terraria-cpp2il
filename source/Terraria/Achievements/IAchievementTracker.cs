using System;
using Cpp2ILInjected;

namespace Terraria.Achievements
{
	// Token: 0x02000495 RID: 1173
	[global::Cpp2ILInjected.Token(Token = "0x200069C")]
	public interface IAchievementTracker
	{
		// Token: 0x0600333B RID: 13115
		[global::Cpp2ILInjected.Token(Token = "0x6003871")]
		void ReportAs(string name);

		// Token: 0x0600333C RID: 13116
		[global::Cpp2ILInjected.Token(Token = "0x6003872")]
		TrackerType GetTrackerType();

		// Token: 0x0600333D RID: 13117
		[global::Cpp2ILInjected.Token(Token = "0x6003873")]
		void Load();

		// Token: 0x0600333E RID: 13118
		[global::Cpp2ILInjected.Token(Token = "0x6003874")]
		void Clear();
	}
}
