import { ChangeDetectorRef, Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Getquiz } from '../../services/getquiz';
import { Takequiz } from '../../services/takequiz';
import { Router } from '@angular/router';

@Component({
  selector: 'app-setup',
  imports: [FormsModule],
  templateUrl: './setup.html',
  styleUrl: './setup.css'
})
export class Setup {

  selectedQuiz: any
  constructor(private getq: Getquiz, private cdr: ChangeDetectorRef,private quizService:Takequiz,private router:Router) { }


  selectQuiz(form: NgForm) {
    console.log("Amount:", form.value.amount);

    let url = `https://opentdb.com/api.php?amount=${form.value.amount}&category=${form.value.category}&difficulty=${form.value.difficulty}&type=multiple`;
    this.getq.getQuestions(url).subscribe((data) => {
      this.selectedQuiz = data.results
      this.cdr.detectChanges();

      this.quizService.setQuizData(data.results)
      console.log(this.selectedQuiz);

          this.router.navigateByUrl("/play");
    })
  }
}


