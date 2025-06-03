pipeline {
    agent any
    environment {
        DOCKERHUB_USERNAME = 'santhoshathili'   
        DOCKERHUB_REPO = 'votingapi'
        IMAGE_TAG = 'latest'
        IMAGE_URI = "${DOCKERHUB_USERNAME}/${DOCKERHUB_REPO}:${IMAGE_TAG}"
    }
    stages {
        stage('Build Docker Image') {
            steps {
                sh 'docker build -t ${IMAGE_URI} .'
            }
        }

        stage('Login to Docker Hub') {
            steps {
                withCredentials([usernamePassword(credentialsId: 'dockerhub-creds', usernameVariable: 'DOCKERHUB_USER', passwordVariable: 'DOCKERHUB_PASS')]) {
                    sh 'echo "$DOCKERHUB_PASS" | docker login -u "$DOCKERHUB_USER" --password-stdin'
                }
            }
        }

        stage('Push Docker Image') {
            steps {
                sh 'docker push ${IMAGE_URI}'
            }
        }
    }

    post {
        always {
            sh 'docker system prune -f'
        }
        success {
            echo 'Docker image pushed to Docker Hub successfully!'
        }
        failure {
            echo 'Pipeline failed. Please check the logs.'
        }
    }
}
