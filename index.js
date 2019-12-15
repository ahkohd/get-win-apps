var exec = require("child_process").exec;
var path = require("path");

function execute(command, callback) {
  exec(path.join(__dirname, command), [], function(error, stdout, stderr) {
    callback(error, stdout, stderr);
  });
}


module.exports = {
  getApps: function() {
      return new Promise((resolve, reject) =>
      execute("get-apps", function(error, apps, stderr) {
        if(error || stderr) {
          reject(error || stderr);
          return;
        }
        var fmt = apps.replace(/\r\n/g, "");
        var lines = fmt.split(";");
        var list = []
        for(var i = 0; i < lines.length; i++) 
        {
          let process = lines[i].split("::");
          list.push({displayName: process[0], displayIcon: process[1], installLocation: process[2]})
        }
        resolve(list);
      })
    );
  }
};
 