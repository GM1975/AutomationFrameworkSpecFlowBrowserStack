/* global process */
"use strict";

var spawn = require("child_process").spawn;
var runningProcesses = [];
var runProcess = function(executeable, args){
	spawn("powershell", 
	  	   ['-Command', 'Start-Process', executeable, ' -ArgumentList', '\"' + args + '\"', '-Wait']);
};

var seleniumJarFilename = "selenium-server-standalone-2.49.1.jar";

var runSeleniumHub = function(){
	var executeable = "java";
	var args = "-jar " + seleniumJarFilename + " -role hub -hubConfig hubConfig.json";
	
	return runProcess(executeable, args);
}

var runSeleniumNode = function(){
	var executeable = "java";
	var driverArgs = " -Dwebdriver.ie.driver=IEDriverServer.exe -Dwebdriver.chrome.driver=chromedriver.exe"
	var args = "-jar " + seleniumJarFilename + " -role webdriver -nodeConfig nodeConfig.json" + driverArgs;
	
	return runProcess(executeable, args);
}

process.on('SIGINT', function () {
  console.log("You will need to manually close the selenium hub & node windows");
  process.exit();
});


console.log("Starting Selenium Hub");
runSeleniumHub();
console.log("Starting Selenium Chrome Node");
runSeleniumNode();
console.log("Selenium Processes started... Press Ctrl+C to exit and leave Selenium running.");

