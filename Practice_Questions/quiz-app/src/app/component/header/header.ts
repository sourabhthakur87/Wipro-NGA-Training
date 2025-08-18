import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-header',
  imports: [RouterLink],
  templateUrl: './header.html',
  styleUrl: './header.css'
})
export class Header {
  isDarkMode: boolean = false;

  ngOnInit(): void {
    const stored = localStorage.getItem('theme');
    this.isDarkMode = stored === 'dark';
    this.applyTheme();
  }

  toggleTheme() {
    this.isDarkMode = !this.isDarkMode;
    localStorage.setItem('theme', this.isDarkMode ? 'dark' : 'light');
    this.applyTheme();
  }

  applyTheme() {
    document.body.classList.remove('light-theme', 'dark-theme');
    document.body.classList.add(this.isDarkMode ? 'dark-theme' : 'light-theme');
  }
}
