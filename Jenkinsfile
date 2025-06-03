pipeline {
  agent any

  environment {
    AWS_REGION = 'ap-south-1'
    ECR_REPO = 'votingapi'
    IMAGE_TAG = "v${env.BUILD_ID}"
    AWS_ACCOUNT_ID = '982081054052'
    ECR_URI = "${AWS_ACCOUNT_ID}.dkr.ecr.${AWS_REGION}.amazonaws.com/${ECR_REPO}:${IMAGE_TAG}"
  }

  stages {
    stage('Build Docker Image') {
      steps {
        sh 'docker build -t $ECR_REPO:$IMAGE_TAG .'
      }
    }

    stage('Login to ECR') {
      steps {
        withCredentials([[$class: 'AmazonWebServicesCredentialsBinding', credentialsId: 'aws-creds']]) {
          sh '''
            aws configure set default.region $AWS_REGION
            aws ecr get-login-password | docker login --username AWS --password-stdin $AWS_ACCOUNT_ID.dkr.ecr.$AWS_REGION.amazonaws.com
          '''
        }
      }
    }

    stage('Push Docker Image') {
      steps {
        sh '''
          docker tag $ECR_REPO:$IMAGE_TAG $ECR_URI
          docker push $ECR_URI
        '''
      }
    }
  }
}

