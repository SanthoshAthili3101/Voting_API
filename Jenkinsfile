pipeline {
  agent any

  environment {
    AWS_REGION = 'ap-south-1'
    ECR_REPO = 'votingapi'
    IMAGE_TAG = "v${env.BUILD_ID}"
  }

  stages {
    stage('Checkout') {
      steps {
        git branch: 'main', credentialsId: 'github-creds', url: 'https://github.com/SanthoshAthili3101/Voting_API.git'
      }
    }

    stage('Build Docker Image') {
      steps {
        sh 'docker build -t $ECR_REPO:$IMAGE_TAG .'
      }
    }

    stage('Login to ECR') {
      steps {
        withCredentials([[$class: 'AmazonWebServicesCredentialsBinding', credentialsId: 'github-creds']]) {
          sh '''
            aws configure set default.region $AWS_REGION
            aws ecr get-login-password | docker login --username AWS --password-stdin 982081054052.dkr.ecr.$AWS_REGION.amazonaws.com
          '''
        }
      }
    }

    stage('Push Docker Image') {
      steps {
        sh 'docker tag $ECR_REPO:$IMAGE_TAG 982081054052.dkr.ecr.$AWS_REGION.amazonaws.com/$ECR_REPO:$IMAGE_TAG'
        sh 'docker push 982081054052.dkr.ecr.$AWS_REGION.amazonaws.com/$ECR_REPO:$IMAGE_TAG'
      }
    }
  }
}
