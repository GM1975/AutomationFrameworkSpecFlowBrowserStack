selenium-grid
=============

Selenium grid stuff

## Setup Grid
Install java 1.7 or higher
	
    java -version
    
Install NodeJS 0.12.x or higher

	node --version


## Running Grid
The NodeJS app will launch a local Selenium Hub + Node with Chrome & Internet Explorer capabilities.

From the selenium-grid repo folder, run 
	
	node index

You should see the following Command Windows running the Hub + Node:

![Selenium Hub and Node](docs/SeleniumHubNode.png)

You can press Ctrl+C on your original command window, and leave the Hub + Node runngin in the background.

## Configuring E2E Projects
Configure e2e project to use grid server on 

	http://localhost:4444/wd/hub
    
## Checking Hub Status
To check the status of the running Hub and Node Capabilities, load the following Url in the Browser:

	http://localhost:4444/grid/console