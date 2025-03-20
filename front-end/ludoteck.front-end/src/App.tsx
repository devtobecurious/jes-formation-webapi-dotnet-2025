import { GameList } from './features/games'

const App = () => {
  return (
    <div className="min-h-screen bg-gray-100">
      <div className="container mx-auto py-8">
        <h1 className="text-4xl font-bold text-center text-gray-800 mb-8">
          Mes Jeux Vidéo
        </h1>
        <GameList />
      </div>
    </div>
  );
};

export default App;
