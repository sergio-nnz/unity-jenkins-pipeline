node ("master") {
  stage("Pull the project") {
    try {
      // checkout([$class: 'GitSCM', branches:[[name: '*/master']], doGenerateSubmoduleConfiguration: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: "", url: ""]]])
    } catch (error) {

    }
  }

  stage("Unit Tests") {
    try {

    } catch (error) {

    }
  }

  stage("Playmode Tests") {
    try {

    } catch (error) {

    }
  }

  stage("Generate Project") {
    try {

    } catch (error) {

    }
  }
}

@NonCPS
def getGitChangeLog()
{

}
