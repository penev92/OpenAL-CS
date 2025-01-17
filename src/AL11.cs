#region License
/* OpenAL# - C# Wrapper for OpenAL Soft
 *
 * Copyright (c) 2014-2015 Ethan Lee.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */
#endregion

#region Using Statements
using System;
using System.Runtime.InteropServices;
#endregion

namespace OpenAL
{
	public static class AL11
	{
		private const string nativeLibName = "soft_oal";

		/* typedef int ALenum; */
		public const int AL_SEC_OFFSET =		0x1024;
		public const int AL_SAMPLE_OFFSET =		0x1025;
		public const int AL_BYTE_OFFSET =		0x1026;

		public const int AL_SPEED_OF_SOUND =		0xC003;

		public const int AL_LINEAR_DISTANCE =		0xD003;
		public const int AL_LINEAR_DISTANCE_CLAMPED =	0xD004;
		public const int AL_EXPONENT_DISTANCE =		0xD005;
		public const int AL_EXPONENT_DISTANCE_CLAMED =	0xD006;

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alSpeedOfSound(float value);
	}
}
