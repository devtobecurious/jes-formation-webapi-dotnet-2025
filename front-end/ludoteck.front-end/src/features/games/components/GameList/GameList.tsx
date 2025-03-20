import { useState, useEffect } from 'react';
import axios from 'axios';
import { Game } from '../../models/Game';
import GameCard from '../GameCard/GameCard';

export const GameList = () => {
  const [games, setGames] = useState<Game[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchGames = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/videogames');
        setGames(response.data);
        setLoading(false);
      } catch (err) {
        setError("Erreur lors du chargement des jeux vidéo");
        setLoading(false);
        console.error("Erreur:", err);
      }
    };

    fetchGames();
  }, []);

  if (loading) {
    return (
      <div className="flex justify-center items-center min-h-[200px]">
        <div className="text-xl text-gray-600">Chargement...</div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="flex justify-center items-center min-h-[200px]">
        <div className="text-xl text-red-600">{error}</div>
      </div>
    );
  }

  return (
    <div className="flex flex-wrap justify-center gap-8 p-8">
      {games.map((game) => (
        <GameCard key={game.id} game={game} />
      ))}
    </div>
  );
};

export default GameList; 