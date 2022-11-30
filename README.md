# Weedwacker
Private Server reimplementation of a certain anime game.
Join us on our [discord](https://discord.gg/XJgJcf6nPf)!

### Features:
- Ability Framework (funeral parlor director's health reduction works correctly, and as intended!)
- Native Lua 5.3 integration
- Independent and highly customizable WebServer powered by microsoft's kestrel with the necessary json data structures properly represented in the code
- Authentication framework
- Organized Avatar framework faithfully reflecting the data and the game design
- A very organized inventory system with type safety
- Use of the Official c# driver for mongodb (with godly documentation), the ability to update, save, delete documents as needed
- Resource loading and management of $type polymorphism
- Extensive debug logging and the option to save to disk (only in the DEBUG build)
- Some basic console commands

### Contributing:
Any contributions, small and large are welcome. The code has to be understandable,
and not hardcode any values whenever possible (ie. when it can be found in the resources).
Code written in c++, lua, and any .NET languages may be accepted, as long as they don't make the repo less cross-platform

### Requirements:
* .NET 6
* [MongoDB](https://www.mongodb.com/try/download/community)

* Proxy Daemon: [Fiddler Classic](https://telerik-fiddler.s3.amazonaws.com/fiddler/FiddlerSetup.exe) (recommended), [mitmproxy](https://mitmproxy.org/) (mitmdump, recommended),  etc.

* [mhypbase patch](https://github.com/Jx2f/mhypbase) _(Optional)_: if you want to enable **Server.Account.UsePassword**, you need to patch yor cilent according to mhypbase project.
### Building:
any .NET 6 compatible compiler

### Running:
Weedwacker has 2 different executables. one for the HTTP web server, one for the UDP game server
- 1) Download and put at the root of the project the [resources](https://git.crepe.moe/tamilpp25/Grasscutter_Resources/-/tree/3.2/) folder
- 1b) Check out [DataParser](https://github.com/WeedwackerPS/DataParser) if you're interested.
- 2) Run both the WebServer and the GameServer executables (also generates the configuration jsons if not present).
- 2b) If you plan to host multiple game server instances, or run over a network, make the appropriate changes/additions to the  config jsons (each server should have its own MongoDB Database).

### Connecting:
½. Make sure you've set up/modified your client correctly to connect to private servers.
1. Create an account on the web server (NOT the game server) using the "createaccount <username>" command from the console, or set AutoCreate to true in WebConfig.json.
2. Use your preferred method to proxy web traffic from official servers to the webserver.
3. Launch the game and play!

### FiddlerScript:
Go to Tools->Options->HTTPS enable Decrypt HTTPS traffic.
use the following script with fiddler to proxy the traffic to your webserver:
```
import System;
import System.Windows.Forms;
import Fiddler;
import System.Text.RegularExpressions;

class Handlers
{
	static function OnBeforeRequest(oS: Session) {
		if(oS.host.EndsWith(".yuanshen.com") || oS.host.EndsWith(".hoyoverse.com") || oS.host.EndsWith(".mihoyo.com")) {
			oS.host = "localhost"; // This can also be replaced with another IP address.
            oS.port = 443; // Change to the port of the WebServer
		}
		
		if (oS.host.Equals("overseauspider.yuanshen.com:8888")) {
            oS.oRequest.FailSession(404, "Blocked", "Not Found");
        }
        
	}
};
```
