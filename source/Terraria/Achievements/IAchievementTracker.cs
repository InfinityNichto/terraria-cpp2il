using System;
using Cpp2ILInjected;

namespace Terraria.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x200069C")]
	public interface IAchievementTracker
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003871")]
		void ReportAs(string name);

		[global::Cpp2ILInjected.Token(Token = "0x6003872")]
		TrackerType GetTrackerType();

		[global::Cpp2ILInjected.Token(Token = "0x6003873")]
		void Load();

		[global::Cpp2ILInjected.Token(Token = "0x6003874")]
		void Clear();
	}
}
