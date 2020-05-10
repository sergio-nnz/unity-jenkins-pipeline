# Jenkins Shared pipeline for Unity projects

To use the shared pipeline you can use the following sample script on your project.

```
@Library('unity-jenkins-pipeline')_
def pipelineParams = {}
node("master") {
    checkout scm
    pipelineParams = readJSON file: 'jenkins-files/pipeline_params.json'
}
StandaloneUnityPipeline(pipelineParams)
```

Configure the following json file with the appropriate parameters and add it to your project alongside the pipeline script:
[Pipeline Parameters](misc/pipelineParams.json)

Finally, add the following script to your unity project inside an 'Editor' folder:
[Build Script](misc/UnityBuildScript.cs)
