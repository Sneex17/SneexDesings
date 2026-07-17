<template>
  <div class="design-wrap">

    <!-- Filtro por categoría -->
    <div v-if="!isLoading && lista.length > 0" class="filter-bar" role="tablist" aria-label="Filtrar por categoría">
      <button v-for="cat in categoryOptions"
              :key="cat"
              type="button"
              class="filter-chip"
              :class="[categoryClass(cat), { active: selectedCategory === cat }]"
              @click="selectedCategory = cat">
        {{ cat }}
        <span v-if="cat !== 'Todos'" class="filter-count">{{ countByCategory(cat) }}</span>
      </button>
    </div>

    <!-- Loading state -->
    <div v-if="isLoading" class="state-msg">
      <div class="spinner"></div>
      <p>Cargando diseños…</p>
    </div>

    <!-- Empty state (sin datos en absoluto) -->
    <div v-else-if="lista.length === 0" class="state-msg">
      <p>Todavía no hay diseños publicados.</p>
    </div>

    <!-- Sin resultados para el filtro activo -->
    <div v-else-if="filteredList.length === 0" class="state-msg">
      <p>No hay diseños en "{{ selectedCategory }}" todavía.</p>
    </div>

    <!-- Grid de diseños -->
    <div v-else class="container-main">
      <article v-for="item in filteredList"
               :key="item.productdesignid"
               class="card-design">
        <div class="card-media">
          <img :src="item.img" :alt="item.title" loading="lazy" />
        </div>
        <div class="card-info">
          <h3 class="card-title">{{ item.title }}</h3>
          <span class="badge" :class="categoryClass(item.category)">
            {{ item.category }}
          </span>
          <p class="card-desc">{{ item.description }}</p>
          <span class="card-date">{{ item.fecha }}</span>
        </div>
      </article>
    </div>

  </div>
</template>

<script setup lang="ts">
  import { ref, computed, onMounted } from 'vue'
  import { type cuerpoDesign } from '../Controllers/DesignController'
  import * as DesignController from '../Controllers/DesignController'

  const lista = ref<cuerpoDesign[]>([])
  const isLoading = ref(true)

  const CATEGORIES = ['Aventureros', 'Conquistadores', 'Guías Mayores', 'Sociedad de Jóvenes'] as const

  const categoryMap: Record<string, string> = {
    Aventureros: 'badge-aventureros',
    Conquistadores: 'badge-conquistadores',
    'Guías Mayores': 'badge-guias',
    'Sociedad de Jóvenes': 'badge-jovenes',
  }

  function categoryClass(category: string): string {
    if (category === 'Todos') return 'badge-todos'
    return categoryMap[category] ?? 'badge-jovenes'
  }

  // Filtro activo. "Todos" muestra la lista completa.
  const selectedCategory = ref<string>('Todos')

  // Solo muestra chips de categorías que realmente tienen diseños.
  const categoryOptions = computed<string[]>(() => {
    const present = CATEGORIES.filter((cat) =>
      lista.value.some((item) => item.category === cat)
    )
    return ['Todos', ...present]
  })

  const filteredList = computed<cuerpoDesign[]>(() => {
    if (selectedCategory.value === 'Todos') return lista.value
    return lista.value.filter((item) => item.category === selectedCategory.value)
  })

  function countByCategory(category: string): number {
    return lista.value.filter((item) => item.category === category).length
  }

  onMounted(async () => {
    try {
      lista.value = await DesignController.Listar()
    } catch (error) {
      console.log('Error: ', error)
    } finally {
      isLoading.value = false
    }
  })
</script>

<style scoped>
  :root {
    --ink: #0b0e14;
    --card: #161a24;
    --card-hover: #1b2030;
    --line: rgba(241, 241, 245, 0.08);
    --text: #f1f1f5;
    --muted: #8a8fa3;
    --violet: #7c5cfc;
    --pink: #ff5d8f;
    --cyan: #3ec6e0;
  }

  .design-wrap {
    padding: 60px 6vw 100px;
    background: var(--ink);
    min-height: 60vh;
  }

  /* ---------- FILTER BAR ---------- */
  .filter-bar {
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
    margin-bottom: 36px;
  }

  .filter-chip {
    display: inline-flex;
    align-items: center;
    gap: 8px;
    font-family: inherit;
    font-size: 0.85rem;
    font-weight: 600;
    color: var(--muted);
    background: var(--card);
    border: 1px solid var(--line);
    border-radius: 999px;
    padding: 8px 16px;
    cursor: pointer;
    transition: transform 0.2s ease, border-color 0.2s ease, color 0.2s ease, background 0.2s ease;
  }

    .filter-chip:hover {
      transform: translateY(-2px);
      color: var(--text);
    }

  .filter-count {
    font-size: 0.72rem;
    font-weight: 700;
    opacity: 0.7;
  }

  /* Chip activo toma el color de su propia categoría */
  .filter-chip.active.badge-todos {
    background: var(--text);
    color: var(--ink);
    border-color: var(--text);
  }

  .filter-chip.active.badge-aventureros {
    background: var(--cyan);
    color: var(--ink);
    border-color: var(--cyan);
  }

  .filter-chip.active.badge-conquistadores {
    background: var(--pink);
    color: var(--ink);
    border-color: var(--pink);
  }

  .filter-chip.active.badge-guias {
    background: var(--violet);
    color: var(--ink);
    border-color: var(--violet);
  }

  .filter-chip.active.badge-jovenes {
    background: var(--muted);
    color: var(--ink);
    border-color: var(--muted);
  }

  /* ---------- GRID ---------- */
  .container-main {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 24px;
  }

  /* ---------- CARD ---------- */
  .card-design {
    background: var(--card);
    border: 1px solid var(--line);
    border-radius: 16px;
    overflow: hidden;
    cursor: pointer;
    transition: transform 0.3s ease, border-color 0.3s ease, background 0.3s ease;
  }

    .card-design:hover {
      transform: translateY(-6px);
      border-color: transparent;
      background: var(--card-hover);
      box-shadow: 0 16px 40px -14px rgba(124, 92, 252, 0.35);
    }

  .card-media {
    width: 100%;
    aspect-ratio: 4 / 5;
    overflow: hidden;
    background: var(--ink);
  }

    .card-media img {
      width: 100%;
      height: 100%;
      object-fit: cover;
      display: block;
      transition: transform 0.4s ease;
    }

  .card-design:hover .card-media img {
    transform: scale(1.06);
  }

  .card-info {
    padding: 18px 18px 20px;
    color: var(--text);
  }

  .card-title {
    font-size: 1.05rem;
    font-weight: 700;
    margin-bottom: 10px;
    letter-spacing: -0.2px;
  }

  .badge {
    display: inline-block;
    font-size: 0.75rem;
    font-weight: 600;
    padding: 4px 12px;
    border-radius: 999px;
    border: 1px solid transparent;
    margin-bottom: 12px;
  }

  .badge-aventureros {
    background: rgba(62, 198, 224, 0.12);
    color: var(--cyan);
    border-color: rgba(62, 198, 224, 0.4);
  }

  .badge-conquistadores {
    background: rgba(255, 93, 143, 0.12);
    color: var(--pink);
    border-color: rgba(255, 93, 143, 0.4);
  }

  .badge-guias {
    background: rgba(124, 92, 252, 0.12);
    color: var(--violet);
    border-color: rgba(124, 92, 252, 0.4);
  }

  .badge-jovenes {
    background: rgba(241, 241, 245, 0.08);
    color: var(--muted);
    border-color: var(--line);
  }

  .card-desc {
    font-size: 0.88rem;
    color: var(--muted);
    line-height: 1.5;
    margin-bottom: 12px;
    display: -webkit-box;
    -webkit-line-clamp: 3;
    -webkit-box-orient: vertical;
    overflow: hidden;
  }

  .card-date {
    font-size: 0.78rem;
    font-weight: 600;
    color: var(--muted);
    opacity: 0.8;
  }

  /* ---------- STATES ---------- */
  .state-msg {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    gap: 14px;
    padding: 80px 0;
    color: var(--muted);
  }

  .spinner {
    width: 32px;
    height: 32px;
    border-radius: 50%;
    border: 3px solid var(--line);
    border-top-color: var(--violet);
    animation: spin 0.8s linear infinite;
  }

  @keyframes spin {
    to {
      transform: rotate(360deg);
    }
  }

  /* ---------- RESPONSIVE ---------- */
  @media screen and (max-width: 1200px) {
    .container-main {
      grid-template-columns: repeat(3, 1fr);
    }
  }

  @media screen and (max-width: 900px) {
    .container-main {
      grid-template-columns: repeat(2, 1fr);
    }
  }

  @media screen and (max-width: 560px) {
    .container-main {
      grid-template-columns: 1fr;
    }
  }

  @media (prefers-reduced-motion: reduce) {
    .card-design,
    .card-media img {
      transition: none;
    }

    .spinner {
      animation: none;
    }
  }
</style>
