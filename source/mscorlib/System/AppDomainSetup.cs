using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000126 RID: 294
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000169")]
	[global::System.Serializable]
	[StructLayout(0)]
	public sealed class AppDomainSetup
	{
		// Token: 0x06000DB3 RID: 3507 RVA: 0x00016C1F File Offset: 0x00014E1F
		[global::Cpp2ILInjected.Token(Token = "0x6000E91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D3C", Offset = "0x1C79D3C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public AppDomainSetup()
		{
			throw null;
		}

		// Token: 0x0400046A RID: 1130
		[global::Cpp2ILInjected.Token(Token = "0x4000630")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string application_base;

		// Token: 0x0400046B RID: 1131
		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string application_name;

		// Token: 0x0400046C RID: 1132
		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string cache_path;

		// Token: 0x0400046D RID: 1133
		[global::Cpp2ILInjected.Token(Token = "0x4000633")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string configuration_file;

		// Token: 0x0400046E RID: 1134
		[global::Cpp2ILInjected.Token(Token = "0x4000634")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string dynamic_base;

		// Token: 0x0400046F RID: 1135
		[global::Cpp2ILInjected.Token(Token = "0x4000635")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string license_file;

		// Token: 0x04000470 RID: 1136
		[global::Cpp2ILInjected.Token(Token = "0x4000636")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string private_bin_path;

		// Token: 0x04000471 RID: 1137
		[global::Cpp2ILInjected.Token(Token = "0x4000637")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string private_bin_path_probe;

		// Token: 0x04000472 RID: 1138
		[global::Cpp2ILInjected.Token(Token = "0x4000638")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string shadow_copy_directories;

		// Token: 0x04000473 RID: 1139
		[global::Cpp2ILInjected.Token(Token = "0x4000639")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string shadow_copy_files;

		// Token: 0x04000474 RID: 1140
		[global::Cpp2ILInjected.Token(Token = "0x400063A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool publisher_policy;

		// Token: 0x04000475 RID: 1141
		[global::Cpp2ILInjected.Token(Token = "0x400063B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool path_changed;

		// Token: 0x04000476 RID: 1142
		[global::Cpp2ILInjected.Token(Token = "0x400063C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int loader_optimization;

		// Token: 0x04000477 RID: 1143
		[global::Cpp2ILInjected.Token(Token = "0x400063D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool disallow_binding_redirects;

		// Token: 0x04000478 RID: 1144
		[global::Cpp2ILInjected.Token(Token = "0x400063E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool disallow_code_downloads;

		// Token: 0x04000479 RID: 1145
		[global::Cpp2ILInjected.Token(Token = "0x400063F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object _activationArguments;

		// Token: 0x0400047A RID: 1146
		[global::Cpp2ILInjected.Token(Token = "0x4000640")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private object domain_initializer;

		// Token: 0x0400047B RID: 1147
		[global::Cpp2ILInjected.Token(Token = "0x4000641")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private object application_trust;

		// Token: 0x0400047C RID: 1148
		[global::Cpp2ILInjected.Token(Token = "0x4000642")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string[] domain_initializer_args;

		// Token: 0x0400047D RID: 1149
		[global::Cpp2ILInjected.Token(Token = "0x4000643")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool disallow_appbase_probe;

		// Token: 0x0400047E RID: 1150
		[global::Cpp2ILInjected.Token(Token = "0x4000644")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private byte[] configuration_bytes;

		// Token: 0x0400047F RID: 1151
		[global::Cpp2ILInjected.Token(Token = "0x4000645")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private byte[] serialized_non_primitives;

		// Token: 0x04000480 RID: 1152
		[global::Cpp2ILInjected.Token(Token = "0x4000646")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string manager_assembly;

		// Token: 0x04000481 RID: 1153
		[global::Cpp2ILInjected.Token(Token = "0x4000647")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string manager_type;

		// Token: 0x04000482 RID: 1154
		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string[] partial_visible_assemblies;

		// Token: 0x04000483 RID: 1155
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string <TargetFrameworkName>k__BackingField;
	}
}
