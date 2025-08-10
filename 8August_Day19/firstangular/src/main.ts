import { platformBrowser } from '@angular/platform-browser';
import { AppModule } from './app/app.module';
import 'zone.js';  // Zone.js is needed for Angular's change detection mechanism.

platformBrowser().bootstrapModule(AppModule, {
  ngZoneEventCoalescing: true,
})
  .catch(err => console.error(err));
