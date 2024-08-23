using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Golf;

namespace Terraria.Physics
{
	// Token: 0x020003A5 RID: 933
	[global::Cpp2ILInjected.Token(Token = "0x2000544")]
	public class PhysicsProperties
	{
		// Token: 0x06002E0C RID: 11788 RVA: 0x0002A38F File Offset: 0x0002858F
		[global::Cpp2ILInjected.Token(Token = "0x600326B")]
		[global::Cpp2ILInjected.Address(RVA = "0x132E344", Offset = "0x132E344", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PhysicsProperties(float gravity, float drag)
		{
			throw null;
		}

		// Token: 0x04003203 RID: 12803
		[global::Cpp2ILInjected.Token(Token = "0x4003BA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly float Gravity;

		// Token: 0x04003204 RID: 12804
		[global::Cpp2ILInjected.Token(Token = "0x4003BA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly float Drag;
	}
}
