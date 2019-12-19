document.addEventListener('DOMContentLoaded', () => {
  
  const navbar = document.querySelector('.navbar');
  
  navbar.querySelector('a.icon').href = 'javascript:void(0);';
  navbar.addEventListener('click', (e) => {
    const el = e.target.parentElement;
    el.className = el.className === 'navbar' ? el.className + ' responsive' : 'navbar';
  }, true);
  
});
