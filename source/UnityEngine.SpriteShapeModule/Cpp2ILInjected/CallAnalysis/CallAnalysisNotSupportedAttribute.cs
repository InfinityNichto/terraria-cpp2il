﻿using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}