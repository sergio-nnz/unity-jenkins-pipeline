pipeline {
    /* Parameters and evironment variables must be changed depending on the
    project.*/
    parameters {
        string(name: "SLAVE_NODE", defaultValue: "Slave_Machine")
    }

    environment {
        UNITY_APP = "C:/\"Program Files\"/Hub/Editor/2018.3.0f2/Editor/Unity.exe"
        UNITY_PROJECT_PATH = "ExampleProject"
        EDIT_MODE_RESULTS = edit_mode_results.xml
        PLAY_MODE_RESULTS = play_mode_results.xml
    }

    stages {
        stage('Play Mode Tests') {
            //
            powershell "cmd.exe /C ${UNITY_APP} -batchmode -runTests -projectPath" +
            " ${WORKSPACE}/${UNITY_PROJECT_NAME} -testResults ${WORKSPACE}/${PLAY_MODE_RESULTS}" +
            " -testPlatform playmode"
        }

        stage('Edit Mode Tests') {
            powershell "cmd.exe /C ${UNITY_APP} -batchmode -runTests -projectPath" +
            " ${WORKSPACE}/${UNITY_PROJECT_NAME} -testResults ${WORKSPACE}/${EDIT_MODE_RESULTS}" +
            " -testPlatform editmode"
        }

        stage('Build Project') {
            powershell "cmd.exe /C ${UNITY_APP} -quit -nographics -projectPath" +
            " ${WORKSPACE}/${UNITY_PROJECT_NAME} -batchmode -executeMethod" +
            " BuildScript.BuildProject"
        }
    }
}
