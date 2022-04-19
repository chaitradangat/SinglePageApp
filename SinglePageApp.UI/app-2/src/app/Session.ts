export class Session {
    isLoggedIn(): boolean{
        return localStorage.getItem('username') == null ? false : true;
    }
    setLoggedInUser(username: string, icon: string): void {
        localStorage.setItem('username', username);
        localStorage.setItem('icon', icon);
    }
    logout(){
        localStorage.clear();
    }
  }