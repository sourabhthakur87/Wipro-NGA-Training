import { Component, OnInit } from '@angular/core';
import { Takequiz } from '../../services/takequiz';
import { Router } from '@angular/router';
import { FormsModule, NgForm } from '@angular/forms';
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-play',
  imports: [FormsModule, NgIf, NgFor],
  templateUrl: './play.html',
  styleUrl: './play.css'
})
export class Play implements OnInit {
  quizData: any[] = [];
  currentQuestionIndex: number = 0;
  selectedAnswer: string = '';
  total: number = 0; // To track score
  isQuizFinished: boolean = false; // To check if quiz is finished
  hasAnswered: boolean = false; // Flag to track if the user has answered the current question
  shuffledAnswers: string[] = [];

  constructor(private quizService: Takequiz, private router: Router) { }

  ngOnInit() {
    this.quizService.quizData$.subscribe((data) => {
      if (data.length === 0) {
        this.router.navigateByUrl('/');
      } else {
        this.quizData = data;
        this.shuffleCurrentQuestionAnswers();

      }
    });
  }

  // Shuffle answers (optional)
  getShuffledAnswers(question: any): string[] {
    const answers = [question.correct_answer, ...question.incorrect_answers];
    return answers.sort(() => Math.random() - 0.5); // Shuffle answers
  }

  // Check the answer and update the score
  checkAns(form: NgForm) {
    if (form.valid) {
      // Check if the answer is correct
      if (this.selectedAnswer === this.quizData[this.currentQuestionIndex].correct_answer) {
        this.total++; // Increment score if answer is correct
      }

      // After submitting, disable Submit and enable Next
      this.hasAnswered = true;
    }
  }

  // Move to next question

  saveQuizDataToLocalStorage() {
    const quizMeta = this.quizData[0]; // Use first question to get quiz metadata

    const result = {
      marks: this.total,
      totalQuestions: this.quizData.length,
      dateTime: new Date().toISOString(), // Save in readable format
      category: quizMeta.category,
      difficulty: quizMeta.difficulty,
    };

    // Get previous history from localStorage
    const existingData = JSON.parse(localStorage.getItem("history") || '[]');

    // Add new result
    existingData.push(result);

    // Save updated history
    localStorage.setItem("history", JSON.stringify(existingData));
  }

  nextQuestion() {
    if (this.currentQuestionIndex < this.quizData.length - 1) {
      this.currentQuestionIndex++;
      this.selectedAnswer = ''; // Reset the selected answer
      this.hasAnswered = false; // Reset the hasAnswered flag for the next question
      this.shuffleCurrentQuestionAnswers();
    } else {
      this.isQuizFinished = true; // If it's the last question, show the result

      this.saveQuizDataToLocalStorage();
    }
  }

  shuffleCurrentQuestionAnswers() {
    const question = this.quizData[this.currentQuestionIndex];
    const answers = [question.correct_answer, ...question.incorrect_answers];
    this.shuffledAnswers = answers.sort(() => Math.random() - 0.5);
  }
  finishquize() {
    this.router.navigateByUrl("/")
  }
}
