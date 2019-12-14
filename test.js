let getWinApps = require("./index");

getWinApps
  .getApps()
  .then(apps => console.log("Apps installed", apps))
  .catch(err => console.log(err));
