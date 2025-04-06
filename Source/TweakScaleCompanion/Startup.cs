/*
	This file is part of TweakScale Companion™
		© 2020-2025 LisiasT

	TweakScale Companion™ is double licensed, as follows:
		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	TweakScale Companion™ is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with TweakScale Companion™. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with TweakScale Companion™. If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using UnityEngine;
using KSPe.Annotations;

namespace TweakScaleCompanion
{
	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	internal class Startup : MonoBehaviour
	{
		[UsedImplicitly]
		private void Start() {
			Log.force("Version {0}"
				, Version.Text
			);
		}
	}
}
