AR Interaction Experiment

This project contains a Unity script to conduct an Augmented Reality (AR) interaction experiment using the Microsoft HoloLens 2 and the XR Interaction Toolkit. The experiment evaluates user interactions with various virtual objects in a 3D space, capturing data on how users interact with these objects under different conditions. This README will guide you through setting up and running the experiment, as well as understanding the data collection process.

Table of Contents
Project Overview
Setup Instructions
Prerequisites
Installation
Running the Experiment
Data Collection and Analysis
Customization
Troubleshooting
License
Project Overview
This Unity project is designed to investigate user interactions with virtual objects in an AR environment. It uses the Microsoft HoloLens 2 to create an immersive AR experience where users interact with objects placed in different spatial quadrants. The experiment captures various metrics related to object interaction, such as the time taken to interact, the user's head movement, and the positioning of objects.

Setup Instructions
Prerequisites
Before you begin, ensure you have the following:

Unity 2020.3 LTS or later: This project is built using Unity 2020.3 LTS. Ensure that you have this version or later installed.
Microsoft HoloLens 2: The experiment is designed for the HoloLens 2 AR headset.
Mixed Reality Toolkit (MRTK): Ensure that MRTK is set up in your Unity project.
XR Interaction Toolkit: Make sure the XR Interaction Toolkit is installed and configured in Unity.
Installation
Clone the Repository: Clone this repository to your local machine.

bash
Copy code under the Master
git clone https://github.com/OJnwobodo/Fitts-LawInAR_PaperCode.git
Open the Project in Unity:

Launch Unity Hub and open the project from the cloned repository folder.
Set Up the Scene:

Open the provided scene in the Assets/Scenes/ directory.
Ensure all necessary prefabs (SphereObject, CubeObject, CarObject, ArrowPrefab, thankYouObject) are correctly assigned in the ObjectControl script within the Unity Inspector.
Configure Player Settings:

Go to Edit > Project Settings > Player, and configure the settings for HoloLens 2.
Set the build target to Universal Windows Platform (UWP).
Build the Project:

Build the project for HoloLens 2 by selecting File > Build Settings.
Choose Universal Windows Platform and configure the build settings as needed.
Running the Experiment
Deploy the Build:

Deploy the built application to your HoloLens 2 device.
Start the Experiment:

Launch the application on the HoloLens 2.
Follow the on-screen instructions to enter your username, session ID, and the number of samples (objects) you wish to interact with.
Interacting with Objects:

Objects will appear in different spatial quadrants around the user. To interact with these objects, use the HoloLens gaze and gesture controls.
An arrow will guide you to the next object after each interaction.
Complete the Experiment:

The experiment ends after you have interacted with the predefined number of objects. A thank you message will be displayed, and the collected data will be saved.
Data Collection and Analysis
Data Saving:

The experiment collects and saves data for each interaction, including object type, position, distance, head movement, and interaction time.
The data is saved as .txt files in the Application.persistentDataPath directory on the device.
Data Files:

intrinsic_data_*.txt: Contains intrinsic matrix data.
extrinsic_data_*.txt: Contains extrinsic matrix data.
remaining_data_*.txt: Contains detailed interaction data, including object type, position, head movement, etc.
Analysis:

Save the data for further analysis. Import the .csv files into your preferred data analysis tool to evaluate the experiment results.
Customization
Modifying Object Types:

You can add or change the types of objects by modifying the SelectPrefab method in the ObjectControl script.
Changing Object Positioning:

Adjust the minDistance and maxDistance variables to control the distance at which objects are placed around the user.
Adjusting Difficulty:

Modify the angle ranges in the DetermineAngleRange method to alter the difficulty levels based on object placement.
Troubleshooting
Objects Not Appearing:

Ensure all prefabs are correctly assigned in the Unity Inspector.
Verify that the script components are correctly attached to the game objects.
Data Not Saving:

Check that the Application.persistentDataPath directory exists and is writable on the HoloLens 2.
Input Issues:

Ensure the Input_Activator script is correctly configured to a GameObject in the scene.
To use this project and the associated dataset, you can cite this study using:

