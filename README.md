## get-win-apps
A Node.Js package that gets all apps installed in a Windows machine.

## Install
```bash
$npm install get-win-apps
```
## Usage
```js
let getWinApps = require('get-win-apps');

getWinApps
    .getApps()
    .then(apps => console.log(apps))
    .catch(err => console.log(err));

    // OUTPUT: [{ displayName: string, displayIcon: string, installLocation: string }]
```
## How it works
See this stackoverflow question to see [how it works.](https://stackoverflow.com/questions/908850/get-installed-applications-in-a-system)

## Development
```bash
git clone https://github.com/ahkohd/get-win-apps.git
cd get-win-apps

// run an example
npm test

// run the compiled exe
npm run dry-run
```
### Compiling `get-apps-win.cs`
The command below helps to compile the `get-apps-win.cs` source code to `exe`. Please modify the command below to make it work on your machine, and also you need `.NET` installed on your Windows machine.

```cmd
c:\\windows\\Microsoft.NET\\Framework\\v<version e.g 3.5>\\csc.exe /t:exe /out:C:\\Users\\<local_current_user>\\<path_to_project-folder>\\get-apps\\get-apps.exe C:\\Users\\<local_current_user>\\<path_to_project-folder>\\get-apps\\get-apps-win.cs 
```

An Example looks like:
```cmd
c:\\windows\\Microsoft.NET\\Framework\\v3.5\\csc.exe /t:exe /out:C:\\Users\\victor\\Documents\\dev-lab\\get-apps\\get-apps.exe C:\\Users\\victor\\Documents\\dev-lab\\get-apps\\get-apps-win.cs
```

## License
[MIT](./LICENSE.md)