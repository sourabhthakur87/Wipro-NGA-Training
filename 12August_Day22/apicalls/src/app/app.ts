import { Component } from '@angular/core';
import { Dataservices } from './services/dataservices';
import { ChangeDetectorRef } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})



export class App {
  posts: any[] = [];

  constructor(
    private dataService: Dataservices,
    private cdr: ChangeDetectorRef
  ) { }

  ngOnInit(): void {
    this.loadPosts();
  }

  loadPosts() {
    this.dataService.getPost().subscribe({
      next: (data) => {
        console.log('API Data:', data);
        this.posts = data;
        this.cdr.detectChanges();
      },
      error: (err) => {
        console.error('Error loading posts:', err);
      }
    });
  }
}
